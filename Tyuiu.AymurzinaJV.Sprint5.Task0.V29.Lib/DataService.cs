using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AymurzinaJV.Sprint5.Task0.V29.Lib
{
    public class DataService : ISprint5Task0V29
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();
            double a = 6.1 * x * x * x + 0.23 * x * x + 1.04 * x;
            a = Math.Round(a, 3);
            File.WriteAllText(path, a.ToString());
            return path;
        }
    }
}
