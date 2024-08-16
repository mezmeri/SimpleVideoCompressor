using Microsoft.Win32;
using SimpleVideoCompressor.Controllers;
using System.Windows;

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

        private void btn_UploadedFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            bool? dialogResult = dialog.ShowDialog();
            if (dialogResult == true)
            {
                textblock_UserFile.Text = dialog.SafeFileName;
                controller.FilePathNameUri = System.IO.Path.GetDirectoryName(dialog.FileName);
                controller.DirectFileName = dialog.SafeFileName;
            }
        }

        private void btn_FilePathUser_Click(object sender, RoutedEventArgs e)
        {
            OpenFolderDialog dialog = new OpenFolderDialog();

            bool? dialogResult = dialog.ShowDialog();
            if (dialogResult == true)
            {
                textblock_UserFilePath.Text = dialog.FolderName;
                controller.UploadPathUri = dialog.FolderName;
            }
        }

        private void btn_StartCompression_Click(object sender, RoutedEventArgs e)
        {
            btn_FilePathUser.IsEnabled = false;
            btn_FileUploadUser.IsEnabled = false;
            btn_StartCompression.IsEnabled = false;
            controller.StartCompression();

            if (controller.FileUploadPathUri != null)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog();
                dialog.DefaultDirectory = controller.FileUploadPathUri;

                btn_FilePathUser.IsEnabled = true;
                btn_FileUploadUser.IsEnabled = true;
                btn_StartCompression.IsEnabled = true;

                textblock_UserFile.Text = "";
                textblock_UserFilePath.Text = "";
            } else
            {
                MessageBox.Show("An error occured.");
            }
        }
    }
}
