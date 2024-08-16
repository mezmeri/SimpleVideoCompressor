using SimpleVideoCompressor.Models;
using SimpleVideoCompressor.Utility;

namespace SimpleVideoCompressor.Controllers
{
    public class MainWindowController
    {
        public string? FilePathNameUri { get; set; }
        public string? DirectFileName { get; set; }
        public string? UploadPathUri { get; set; }

        /// <summary>
        /// The path to the compressed file.
        /// </summary>
        public string? FileUploadPathUri { get; set; }

        public bool StartCompression()
        {
            File file = new(FilePathNameUri, DirectFileName);
            FileUploadPathUri = VideoCompressor.CompressMedia_H265_HEVC(file, UploadPathUri);
            if(FileUploadPathUri == null)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
