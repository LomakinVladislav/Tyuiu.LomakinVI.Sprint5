using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.LomakinVI.Sprint5.Task5.V30.Lib
{
    public class DataService : ISprint5Task5V30
    {
        public double LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                double m = int.MinValue;
                while ((line = reader.ReadLine()) != null)
                {
                    bool flag = false;
                    double num = Convert.ToDouble(line);


                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            flag = true;
                            continue;
                        }
                    }

                    if (flag == false && num >= m && num % 1 == 0)
                    {
                        m = num;
                    }
                }

                return m;
            }
        }
    }
}
