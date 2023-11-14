using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint5.Task0.V25.Lib;
using System.IO;

namespace Tyuiu.LomakinVI.Sprint5.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\OneSmile\source\repos\Tyuiu.LomakinVI.Sprint5.Task0.V25\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(false, fileExists);
        }
    }
}
