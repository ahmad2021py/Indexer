using System.IO;

namespace Indexer.Utilites
{
    public static class WorkWithDirectory
    {
        /// <summary>
        /// Create a Directory is Not Exist 
        /// </summary>
        /// Tip : Path Must With File and Extension .for example : "C:\Users\Administrator\Desktop\Indexer\code.txt"
        /// <param name="path"></param>
        /// <returns></returns>
        public static string CreateDirectoryIfMissing(string directoryName, string path)
        {
            if (directoryName == "" ||
                directoryName == "CON" ||
                directoryName == "PRN" ||
                directoryName == "AUX" ||
                directoryName == "NUL" ||
                directoryName == "COM1" ||
                directoryName == "COM2" ||
                directoryName == "COM3" ||
                directoryName == "COM4" ||
                directoryName == "COM5" ||
                directoryName == "COM6" ||
                directoryName == "COM7" ||
                directoryName == "COM8" ||
                directoryName == "COM9" ||
                directoryName == "LPT1" ||
                directoryName == "LPT2" ||
                directoryName == "LPT3" ||
                directoryName == "LPT4" ||
                directoryName == "LPT5" ||
                directoryName == "LPT6" ||
                directoryName == "LPT7" ||
                directoryName == "LPT8" ||
                directoryName == "LPT9" ||
                directoryName.Contains("<") ||
                directoryName.Contains(">") ||
                directoryName.Contains(":") ||
                directoryName.Contains("“") ||
                directoryName.Contains("/") ||
                directoryName.Contains(@"\") ||
                directoryName.Contains("|") ||
                directoryName.Contains("?") ||
                directoryName.Contains("*")

                )
            {

                return "Invalid Name";// InValid Name
            }


            bool folderExists = Directory.Exists(path);
            if (folderExists)
            {
                return "Folder Is Exist";
            }

            if (!folderExists)
            {
                Directory.CreateDirectory(path);
                return "True";
            }
            return "True";

        }
    }
}
