using System.IO;
using System.Reflection;
using System.Windows;

namespace BarcodeFileSearch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DirectoryInfo datasheetsDir;
        
        public MainWindow()
        {
            InitializeComponent();
            string executableDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string datasheetsPath = Path.Combine(executableDir, "datasheets");
            datasheetsDir = new DirectoryInfo(datasheetsPath);
        }

        private void textBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (listBox != null)
            {
                listBox.Items.Clear();
                try
                {
                    foreach (var directory in datasheetsDir.EnumerateDirectories(textBox.Text))
                    {
                        listBox.Items.Add(directory.Name);
                    }
                }
                catch (DirectoryNotFoundException)
                {
                    // Directory not found - leave list empty
                }
            }
        }

        private void listBox_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var item = (string)listBox.SelectedItem;
            string fullPath = Path.Combine(datasheetsDir.FullName, item);
            
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = fullPath,
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
