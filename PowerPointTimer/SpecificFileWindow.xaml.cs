using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace PowerPointTimer
{
    /// <summary>
    /// SpecificFileWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SpecificFileWindow : Window
    {
        public SpecificFileWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = SharedResource.setting.PresentationList;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Microsoft PowerPoint Presentation|*.pptx;*.ppt";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (var i in openFileDialog.FileNames)
                {
                    if (!SharedResource.setting.PresentationExist(i))
                    {
                        SharedResource.setting.PresentationList.Add(new Presentation(i, 0, 5, 0));
                    }
                }
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            try
            {
                if ((string) e.Column.Header == "Hour")
                {
                    var textBox = (System.Windows.Controls.TextBox) e.EditingElement;
                    if (Convert.ToInt32(textBox.Text) >= 24)
                        textBox.Text = 23.ToString();
                }
                else if ((string)e.Column.Header != "FilePath")
                {
                    var textBox = (System.Windows.Controls.TextBox) e.EditingElement;
                    if (Convert.ToInt32(textBox.Text) >= 60)
                        textBox.Text = 59.ToString();
                }
            }
            catch
            {
                var textBox = (System.Windows.Controls.TextBox)e.EditingElement;
                textBox.Text = 0.ToString();
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedIndex == -1)
                return;
            SharedResource.setting.PresentationList.Remove(dataGrid.SelectedItem as Presentation);
        }
    }
}
