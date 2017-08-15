using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PowerPointTimer
{
    /// <summary>
    /// SettingWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SettingWindow : Window
    {
        public SettingWindow()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            hour.Text = (SharedResource.setting.CountdownLen / 3600).ToString();
            minute.Text = (SharedResource.setting.CountdownLen % 3600 / 60).ToString();
            second.Text = (SharedResource.setting.CountdownLen % 60).ToString();
            comboBox.SelectedIndex = SharedResource.setting.DefaultLocation;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (hour.Text == string.Empty)
                hour.Text = "0";
            if (minute.Text == string.Empty)
                minute.Text = "0";
            if (second.Text == string.Empty)
                second.Text = "0";
            if (SyncWithSetting())
                this.Close();
        }

        private bool SyncWithSetting()
        {
            int tLength = Convert.ToByte(hour.Text) * 3600 +
                          Convert.ToByte(minute.Text) * 60 +
                          Convert.ToByte(second.Text);
            if (tLength == 0)
            {
                MessageBox.Show("The Length can't be zero.");
                return false;
            }
            SharedResource.setting.CountdownLen = tLength;
            SharedResource.setting.DefaultLocation = comboBox.SelectedIndex;
            return true;
        }

        private void NumberFilter(object sender, TextCompositionEventArgs e)
        {
            Regex re = new Regex("[^0-9.]+");
            e.Handled = re.IsMatch(e.Text);
        }

        private void NumberLimiter(object sender, TextChangedEventArgs e)
        {
            var textBox = (TextBox)sender;
            int limit = textBox.Equals(hour) ? 24 : 60;
            if (textBox.Text == string.Empty) return;
            try
            {
                int t = Convert.ToInt32(textBox.Text);
                if (t >= limit)
                    throw new Exception("Number too large");
                textBox.Text = t.ToString();
                textBox.SelectionStart = textBox.Text.Length;
            }
            catch (Exception ex)
            {
                textBox.Text = (limit - 1).ToString();
            }
        }

        private void btnSpecific_Click(object sender, RoutedEventArgs e)
        {
            SpecificFileWindow specificFileWindow = new SpecificFileWindow();
            specificFileWindow.ShowDialog();
        }

        private void SettingWindow_Closed(object sender, EventArgs e)
        {
            SharedResource.setting.Save();
        }
    }
}
