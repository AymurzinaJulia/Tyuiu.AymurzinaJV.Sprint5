using Tyuiu.AymurzinaJV.Sprint5.Task4.V22.Lib;
namespace Tyuiu.AymurzinaJV.Sprint5.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V22.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileexist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileexist);
        }
    }
}
