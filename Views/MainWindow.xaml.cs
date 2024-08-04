using SimpleVideoCompressor.Controllers;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleVideoCompressor
{
    public partial class MainWindow : Window
    {
        private MainWindowController controller;
        public MainWindow()
        {
            InitializeComponent();
            controller = new();
            DataContext = controller;
        }

        private void btn_FileUploadUser_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();

            bool? dialogResult = dialog.ShowDialog();
            if (dialogResult == true)
            {
                textblock_UserFile.Text = dialog.SafeFileName;
            }
        }

        private void btn_FilePathUser_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFolderDialog();

            bool? dialogResult = dialog.ShowDialog();
            if (dialogResult == true)
            {
                textblock_UserFilePath.Text = dialog.FolderName;
            }
        }
    }
}