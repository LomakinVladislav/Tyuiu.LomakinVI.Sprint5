using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.LomakinVI.Sprint5.Task1.V29.Lib;

namespace Tyuiu.LomakinVI.Sprint5.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {   
            string path = @"C:\Users\OneSmiLe\source\repos\Tyuiu.LomakinVI.Sprint5\Tyuiu.LomakinVI.Sprint5.Task1.V29\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}
