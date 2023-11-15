using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.LomakinVI.Sprint5.Task1.V29.Lib
{
    public class DataService : ISprint5Task1V29
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;
            for (int x = startValue; x <= stopValue ; x++)
            {
                y = Math.Round((Math.Sin(x) / (x + 1.2) + Math.Cos(x) * 7 * x - 2), 2);
                
                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    if (x == -1.2)
                    {
                        File.AppendAllText(path, 0 + Environment.NewLine);
                    }

                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    if (x == -1.2)
                    {
                        File.AppendAllText(path, 0 + Environment.NewLine);
                    }

                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
