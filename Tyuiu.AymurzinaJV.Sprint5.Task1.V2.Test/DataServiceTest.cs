using Tyuiu.AymurzinaJV.Sprint5.Task1.V2.Lib;
namespace Tyuiu.AymurzinaJV.Sprint5.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(-5, 5);

            FileInfo fileinfo = new FileInfo(path);
            bool fileexist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileexist);
        }
    }
}
