namespace SimpleVideoCompressor.Models
{
    public class File
    {
        /// <summary>
        /// Contains the absolute path to the file.
        /// </summary>
        public string? PathNameUri { get; set; }

        /// <summary>
        /// Gets the file name and extension.
        /// </summary>
        public string? DirectName { get; private set; }


        public File(string pathName, string directName)
        {
            PathNameUri = pathName.Replace("\\", "/");
            DirectName = directName.Replace("\\", "/");
        }
    }
}
