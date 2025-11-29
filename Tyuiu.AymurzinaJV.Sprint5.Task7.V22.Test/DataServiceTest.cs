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
            string path = @"C:\Users\plans\source\repos\Tyuiu.AymurzinaJV.Sprint5\Tyuiu.AymurzinaJV.Sprint5.Task7.V22\bin\Debug\net8.0\OutPutDataFileTask7V22.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
