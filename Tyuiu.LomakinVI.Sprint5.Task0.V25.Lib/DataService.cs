using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.LomakinVI.Sprint5.Task0.V25.Lib
{
    public class DataService : ISprint5Task0V25
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            double chisl = 3 * Math.Pow(x, 4) + 1;
            double znam = Math.Pow(x, 3);

            double result = Math.Round(chisl / znam, 3);

            File.WriteAllText(path, Convert.ToString(result));
            return path;
        }
    }
}
