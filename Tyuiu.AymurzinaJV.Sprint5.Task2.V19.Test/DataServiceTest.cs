using System.IO;
using Tyuiu.AymurzinaJV.Sprint5.Task2.V19.Lib;
namespace Tyuiu.AymurzinaJV.Sprint5.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] matrix = { { 9, 2, 5},
                              { 8, 8, 2},
                              { 7, 4, 8} };
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(matrix);

            FileInfo fileinfo = new FileInfo(path);
            bool fileexist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileexist);
        }
    }
}
