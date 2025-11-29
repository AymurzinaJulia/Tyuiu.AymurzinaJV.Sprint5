using System.IO;
using Tyuiu.AymurzinaJV.Sprint5.Task7.V22.Lib;
namespace Tyuiu.AymurzinaJV.Sprint5.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask7V22.txt";
            string pathSaveFile = ds.LoadDataAndSave(path); 
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
