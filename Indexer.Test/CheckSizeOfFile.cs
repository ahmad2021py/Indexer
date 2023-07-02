using Indexer.Utilites;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Indexer.Test
{
    [TestClass]
    public class CheckSizeOfFile
    {
        [TestMethod]
        public void GetSizeOfFile_____Get__a_Correct_File_Path____Return_Size()
        {
            ///arrange
            string path = Environment.CurrentDirectory + @"\" + "fix.zip";
            var expected = "48Kb";
            ///act
            string actual = WorkWithFile.GetSizeOfFile(path);

            ///assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GetSizeOfFile_____Get__a_Correct_File_Path2____Return_Size()
        {
            ///arrange
            string path = @"C:\Users\Administrator\Desktop\fix.zip";
            var expected = "48Kb";
            ///act
            string actual = WorkWithFile.GetSizeOfFile(path);

            ///assert
            Assert.AreEqual(expected, actual);
        }
    }
}
