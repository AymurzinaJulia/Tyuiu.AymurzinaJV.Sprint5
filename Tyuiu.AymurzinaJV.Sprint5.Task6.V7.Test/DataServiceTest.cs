using System.IO;
using Tyuiu.AymurzinaJV.Sprint5.Task6.V7.Lib;
namespace Tyuiu.AymurzinaJV.Sprint5.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V7.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileexist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileexist);
        }
    }
}
