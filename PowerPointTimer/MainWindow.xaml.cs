using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Microsoft.Office.Core;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace PowerPointTimer
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public enum WindowLocation
        {
            TOPLEFT,
            TOPRIGHT
        };

        private PowerPoint.Application ppt;
        private System.Timers.Timer clock;
        private System.Timers.Timer pptMonitor;
        private int timeLeft;

        public MainWindow()
        {
            InitializeComponent();
            this.Height = 75;
            this.Background = Brushes.Transparent;
            this.Closed += (sender, args) =>
            {
                if (ppt == null) return;
                if (ppt.Presentations.Count == 0)
                    ppt.Quit();
                GC.Collect();
            };
            LoadSettings();
            RefreshUI();
            MoveWindow((WindowLocation)SharedResource.setting.DefaultLocation);
            ClockConfig();
            MonitorConfig();
        }

        private void LoadSettings()
        {
            timeLeft = SharedResource.setting.CountdownLen;
        }

        private void RefreshUI()
        {
            label.Content = Helper.Time2Str(SharedResource.setting.CountdownLen);
        }

        private void MonitorConfig()
        {
            pptMonitor = new System.Timers.Timer();
            pptMonitor.Elapsed += (sender, args) =>
            {
                if (Process.GetProcessesByName("POWERPNT").Length > 0)
                {
                    Dispatcher.Invoke(() =>
                    {
                        AppConfig();
                        pptMonitor.Stop();
                    });
                }
            };
            pptMonitor.Interval = 100;
            pptMonitor.Start();
        }

        private void ClockConfig()
        {
            clock = new System.Timers.Timer();
            clock.Elapsed += (sender, args) =>
            {
                Dispatcher.BeginInvoke((Action)(() =>
                {
                    timeLeft -= 1;
                    label.Content = Helper.Time2Str(timeLeft);
                    if (timeLeft == 0) clock.Stop();
                }));
            };
            clock.Interval = 1000;
        }

        private void AppConfig()
        {
            ppt = new PowerPoint.Application();
            ppt.Visible = MsoTriState.msoTrue;
            ppt.Activate();
            ppt.SlideShowBegin += (window) =>
            {
                Dispatcher.BeginInvoke((Action)(() =>
                {
                    timeLeft = SharedResource.setting.GetLength(window.Presentation.FullName);
                    label.Content = Helper.Time2Str(timeLeft);
                    clock.Start();
                    btnSettings.IsEnabled = false;
                }));
            };
            ppt.SlideShowEnd += (window) =>
            {
                Dispatcher.BeginInvoke((Action) (() =>
                {
                    clock.Stop();
                    btnSettings.IsEnabled = true;
                }));
            };
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            var settingWindow = new SettingWindow();
            settingWindow.ShowDialog();
            RefreshUI();
            timeLeft = SharedResource.setting.CountdownLen;
        }

        private void MoveWindow(WindowLocation location)
        {
            switch (location)
            {
                case WindowLocation.TOPLEFT:
                    this.Left = 0;
                    this.Top = 0;
                    break;
                case WindowLocation.TOPRIGHT:
                    this.Left = Helper.GetScreenWidth() - this.Width;
                    this.Top = 0;
                    break;
            }
        }

        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void MainWindow_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Height = 240;
            this.Background = Brushes.White;
        }

        private void MainWindow_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Height = 75;
            this.Background = Brushes.Transparent;
        }
    }
}
