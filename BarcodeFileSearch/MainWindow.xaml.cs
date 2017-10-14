using System.IO;
using System.Windows;

namespace BarcodeFileSearch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DirectoryInfo dir = new DirectoryInfo("datasheets");
        public MainWindow()
        {
            InitializeComponent();

        }

        private void textBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (listBox != null)
            {
                listBox.Items.Clear();
                foreach (var dir in dir.EnumerateDirectories(textBox.Text))
                {
                    listBox.Items.Add(dir.Name);
                }
            }
        }

        private void listBox_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var item = (string)listBox.SelectedItem;

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = dir.Name + @"\" + item,
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
        }
    }
}
