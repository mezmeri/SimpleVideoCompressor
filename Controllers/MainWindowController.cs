using SimpleVideoCompressor.Utility;
using System;

namespace SimpleVideoCompressor.Controllers
{
    public class MainWindowController
    {
        public string UserFilePath { get; set; }
        public string CompressedFileUploadPath { get; set; }



        public MainWindowController()
        { 

        }

        public void StartCompression()
        {
            VideoCompressor.CompressVideo(UserFilePath, CompressedFileUploadPath);
        }
    }
}
