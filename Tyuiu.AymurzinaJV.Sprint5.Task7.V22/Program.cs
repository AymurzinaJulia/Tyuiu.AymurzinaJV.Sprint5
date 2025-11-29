using System.IO;
using Tyuiu.AymurzinaJV.Sprint5.Task7.V22.Lib;
Console.Title = "Спринт #5 | Выполнила: Аймурзина Ю. В. | РППб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #22                                                             *");
Console.WriteLine("* Выполнила: Аймурзина Юлия Владимировна | РППб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask7V22.txt (файл взять из архива *");
Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:/DataSprint5/ и      *");
Console.WriteLine("* скопировать в неё файл) в котором есть набор символьных данных.Заменить *");
Console.WriteLine("* все знаки препинания на #.Полученный результат сохранить в файл         *");
Console.WriteLine("* OutPutDataFileTask7V22.txt.                                             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
string path = @"C:\DataSprint5\InPutDataFileTask7V22.txt";
string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7.txt";

Console.WriteLine(" Данные находятся в файле: " + path);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Находится в файле: ");
pathSaveFile = ds.LoadDataAndSave(path);
Console.WriteLine(pathSaveFile);

Console.ReadKey();