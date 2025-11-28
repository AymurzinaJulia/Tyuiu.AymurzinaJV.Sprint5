using Tyuiu.AymurzinaJV.Sprint5.Task0.V29.Lib;
int x = 3;

DataService ds = new DataService();

string res = ds.SaveToFileTextData(x);
Console.WriteLine(res);
Console.ReadKey();
