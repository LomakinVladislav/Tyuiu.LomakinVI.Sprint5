using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.LomakinVI.Sprint5.Task3.V19.Lib;

namespace Tyuiu.LomakinVI.Sprint5.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\OneSmiLe\source\repos\Tyuiu.LomakinVI.Sprint5\Tyuiu.LomakinVI.Sprint5.Task3.V19\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
