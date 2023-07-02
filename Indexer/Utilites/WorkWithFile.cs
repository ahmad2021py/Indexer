using System.IO;

namespace Indexer.Utilites
{
    public static class WorkWithFile
    {
        /// <summary>
        /// Get Size Of A File .
        /// bug : If File < 1Kb .Not Show Size
        /// </summary>
        /// <param name="FilePath"></param>
        /// <returns></returns>
        public static string GetSizeOfFile(string FilePath)
        {
            FileInfo FileVol = new FileInfo(FilePath);
            string fileLength = FileVol.Length.ToString();
            string length = string.Empty;
            if (FileVol.Length >= (1 << 10))
                length = string.Format("{0}Kb", FileVol.Length >> 10);
            return length;
        }


        public static void RenameAFile(FileInfo SourcePath, string newName)
        {
            SourcePath.MoveTo(newName);
        }
    }
}
