using System.IO;
using Tyuiu.KovalenkoMA.Sprint6.Task5.V4.Lib;
namespace Tyuiu.KovalenkoMA.Sprint6.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\Марго\source\repos\Tyuiu.KovalenkoMA.Sprint6\Tyuiu.KovalenkoMA.Sprint6.Task5.V4\bin\Debug\InPutDataFileTask5V4.txt";
            FileInfo fileinto = new FileInfo(path);
            bool fileExists = fileinto.Exists;
            Assert.AreEqual(true, fileExists);
        }  
    }
}
