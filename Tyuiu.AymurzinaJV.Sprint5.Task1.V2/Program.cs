using Tyuiu.AymurzinaJV.Sprint5.Task1.V2.Lib;
DataService ds =  new DataService();
int start = -5;
int end = 5;
string res = ds.SaveToFileTextData(start, end);
Console.WriteLine(res);