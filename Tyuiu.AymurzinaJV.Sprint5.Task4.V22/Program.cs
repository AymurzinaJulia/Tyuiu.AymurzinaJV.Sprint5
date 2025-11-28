using Tyuiu.AymurzinaJV.Sprint5.Task4.V22.Lib;
DataService ds = new DataService();

string path = @"C:\DataSprint5\InPutDataFileTask4V22.txt";
double res = ds.LoadFromDataFile(path);

Console.WriteLine(res);
Console.ReadKey();