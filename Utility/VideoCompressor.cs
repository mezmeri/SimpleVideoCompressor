using System.Diagnostics;

namespace SimpleVideoCompressor.Utility
{
    public class VideoCompressor
    {
        public static string GenerateFileName()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }

        public static string CompressMedia_H265_HEVC(Models.File file, string uploadPathUri)
        {
            uploadPathUri = uploadPathUri.Replace("\\", "/");
            string fileName = GenerateFileName();
            try
            {
                using (Process process = new Process())
                {
                    string? ffmpegPath = Environment.GetEnvironmentVariable("FFMPEG_PATH");
                    process.StartInfo.FileName = ffmpegPath.Replace("\\", "/");

                    process.StartInfo.Arguments = $"-i \"{file.PathNameUri}/{file.DirectName}\" -c:v hevc {uploadPathUri}/{fileName}.mp4";

                    process.StartInfo.CreateNoWindow = false;
                    process.StartInfo.UseShellExecute = false;

                    process.Start();
                    process.WaitForExit();

                    if(process.ExitCode == 0)
                    {
                        return uploadPathUri;
                    } else
                    {
                        return null;
                    }
                }
            }
            catch (SystemException e)
            {
                throw new SystemException(e.Message);
            }
        }
    }
}
