using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.LomakinVI.Sprint5.Task6.V19.Lib
{
    public class DataService : ISprint5Task6V19
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;

            using(StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] myArrayLine = line.Split();
                    foreach (string item in myArrayLine)
                    {
                        if (int.TryParse(item, out int n) && item.Length == 2)
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
    }
}
