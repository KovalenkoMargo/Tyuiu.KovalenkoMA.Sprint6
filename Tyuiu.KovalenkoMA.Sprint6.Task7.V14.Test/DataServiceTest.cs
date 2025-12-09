using Tyuiu.KovalenkoMA.Sprint6.Task7.V14.Lib;
namespace Tyuiu.KovalenkoMA.Sprint6.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            // 1. Создаем тестовый CSV файл
            string path = @"C:\TestData\InPutFileTask7V14.csv";
            Directory.CreateDirectory(Path.GetDirectoryName(path));

            // Тестовые данные: 3x3 матрица
            string[] testData = {
                "1;2;3",
                "4;5;6",  // Вторая строка: 4(четное)→44, 5(нечетное)→5, 6(четное)→44
                "7;8;9"
            };

            File.WriteAllLines(path, testData);

            // 2. Тестируем
            DataService ds = new DataService();
            int[,] result = ds.GetMatrix(path);
            // 3. Проверяем изменения во второй строке
            Assert.AreEqual(44, result[1, 0]); // 4 → 44
            Assert.AreEqual(5, result[1, 1]);  // 5 → 5 (не изменилось)
            Assert.AreEqual(44, result[1, 2]); // 6 → 44

            // 4. Проверяем что другие строки не изменились
            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(7, result[2, 0]);

            // 5. Удаляем тестовый файл
            File.Delete(path);
        }
    }
}
