using System.Diagnostics;
using System.IO;

namespace SimpleVideoCompressor.Utility
{
    public class VideoCompressor
    {
		public static string GenerateFileName()
		{
			Guid guid = Guid.NewGuid();
			return guid.ToString();
		}

        public static void CompressVideo(string filePathUri, string uploadPathUri)
        {
			try
			{
				using (Process process = new Process())
				{
					string fileName = GenerateFileName();

					process.StartInfo.FileName = "";

                    process.StartInfo.Arguments = $"ffmpeg -i {filePathUri} -c:v hevc C:/Users/Mads/Videos/Test/{fileName}.mp4";

					process.StartInfo.CreateNoWindow = false;

					process.Start();
					process.WaitForExitAsync();
				}
			}
			catch (SystemException e)
			{
				throw new SystemException(e.Message);
			}
        }
    }
}
