using Tyuiu.AymurzinaJV.Sprint5.Task0.V29.Lib;
namespace Tyuiu.AymurzinaJV.Sprint5.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);
            
            FileInfo fileinfo = new FileInfo(path);
            bool fileexist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileexist);
        }
    }
}
