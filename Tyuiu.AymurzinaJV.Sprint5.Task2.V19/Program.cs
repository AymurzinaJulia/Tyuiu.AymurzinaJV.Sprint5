using Tyuiu.AymurzinaJV.Sprint5.Task2.V19.Lib;

int[,] matrix = { { 9, 2, 5},
                  { 8, 8, 2},
                  { 7, 4, 8} };

int rows = matrix.GetLength(0);
int cols = matrix.GetLength(1);

DataService ds = new DataService();

string res = ds.SaveToFileTextData(matrix);
Console.WriteLine(res);