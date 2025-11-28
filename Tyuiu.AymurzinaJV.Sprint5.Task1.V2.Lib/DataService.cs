using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AymurzinaJV.Sprint5.Task1.V2.Lib
{
    public class DataService : ISprint5Task1V2
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.GetTempFileName();
            for (int x = startValue; x <= stopValue; x++)
            {
                double res;
                if (Math.Cos(x) - 2 * x == 0) res = 0;
                else
                {
                    res = Math.Round((2 * x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - 6, 2);
                }
                if (x == stopValue) File.AppendAllText(path, res.ToString());

                else File.AppendAllText(path, res.ToString() + "\n");

            }
            return path;
        }
    }
}
