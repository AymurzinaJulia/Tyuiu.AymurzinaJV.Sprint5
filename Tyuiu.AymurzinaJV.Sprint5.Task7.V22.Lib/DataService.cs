using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AymurzinaJV.Sprint5.Task7.V22.Lib
{
    public class DataService : ISprint5Task7V22
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Directory.GetCurrentDirectory(), "OutPutDataFileTask7V22.txt");

            FileInfo fileinfo = new FileInfo(pathSaveFile);
            bool fileExists = fileinfo.Exists;
            if (fileExists) File.Delete(pathSaveFile);

            string str = "";

            using(StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] == '!') || (line[i] == '?') || (line[i] == '-') || (line[i] == '.') || (line[i] == ','))
                        {
                            str += '#';
                        }
                        else
                        {
                            str += line[i];
                        }
                    }
                    File.AppendAllText(pathSaveFile, str + "\n");
                    str = "";
                }
            }
            return pathSaveFile;
        }
    }
}
