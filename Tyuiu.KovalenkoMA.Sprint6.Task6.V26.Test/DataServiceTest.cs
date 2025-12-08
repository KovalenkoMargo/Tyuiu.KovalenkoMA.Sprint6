using Tyuiu.KovalenkoMA.Sprint6.Task6.V26;
using Tyuiu.KovalenkoMA.Sprint6.Task6.V26.Lib;
namespace Tyuiu.KovalenkoMA.Sprint6.Task6.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\TestData\InPutFileTask6V26.txt";

            Directory.CreateDirectory(Path.GetDirectoryName(path));

            string[] testData = {
                "Привет мир программирование", 
                "C# лучший язык",
                "Visual Studio 2022",
                "Спринт 6 задание 6",
                "Последнее слово"
            };

            File.WriteAllLines(path, testData);

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(path);

            string expected = "программирование язык 2022 6 слово";


            Assert.AreEqual(expected, result);

            File.Delete(path);
        }
    }
}
