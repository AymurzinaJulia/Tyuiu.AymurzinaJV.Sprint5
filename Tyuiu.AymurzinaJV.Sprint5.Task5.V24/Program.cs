using System.IO;
using Tyuiu.AymurzinaJV.Sprint5.Task5.V24.Lib;
DataService ds = new DataService();
string path = @"C:\DataSprint5\InPutDataFileTask5V24.txt";
double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadKey();
