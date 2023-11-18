using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.LomakinVI.Sprint5.Task3.V19.Lib
{
    public class DataService : ISprint5Task3V19
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";

            double chisl = 2 * Math.Pow(x, 2) - 1;
            double znam = Math.Sqrt(Math.Pow(x, 2) - 2);
            double y = Math.Round(chisl / znam, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            return path;
        }
    }
}
