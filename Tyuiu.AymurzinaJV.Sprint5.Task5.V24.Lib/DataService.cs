using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AymurzinaJV.Sprint5.Task5.V24.Lib
{
    public class DataService : ISprint5Task5V24
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader =  new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    foreach (string a in numbers)
                    {
                        double num = Convert.ToDouble(a.Replace(".", ","));
                        if (num % 1 == 0 && num >= 10 && num <= 99)
                            res += num;
                    }
                }
            }
            return res;
        }
    }
}
