using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint5.Task7.V12.Lib;
using System.IO;

namespace Tyuiu.LomakinVI.Sprint5.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExist()
        {
            string path = @"C:\Users\OneSmiLe\source\repos\Tyuiu.LomakinVI.Sprint5\Tyuiu.LomakinVI.Sprint5.Task7.V12\bin\Debug\OutPutDataFileTask7V12.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
