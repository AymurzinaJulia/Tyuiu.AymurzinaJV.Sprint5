using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AymurzinaJV.Sprint5.Task4.V22.Lib
{
    public class DataService : ISprint5Task4V22
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path).Replace(".", ",");
            double x = Convert.ToDouble(str);
            double res = Math.Round(x * x * x * Math.Sin(x) - 4 * x, 3);
            return res;
        }
    }
}
