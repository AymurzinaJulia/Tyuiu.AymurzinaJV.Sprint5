using System.IO;
using Tyuiu.AymurzinaJV.Sprint5.Task6.V7.Lib;
DataService ds = new DataService();
string path = @"C:\DataSprint5\InPutDataFileTask6V7.txt";
double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadKey();