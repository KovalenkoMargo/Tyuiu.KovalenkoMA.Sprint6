using Tyuiu.KovalenkoMA.Sprint6.Task3.V4.Lib;
namespace Tyuiu.KovalenkoMA.Sprint6.Task3.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int[,] matrix = {
                { -14,  -7,  18,  12, -20 },
                {  -2, -15, -19, -19,  -3 },
                { -18,  -5, -10,  14, -17 },
                {  -1,   2, -10,   0,  11 },
                {   6, -18,   0,  19,  16 }
            };

            int[,] expected = {
                { -14,  -7,  18,  12, -20 },
                {   0, -15, -19, -19,  -3 }, 
                { -18,  -5, -10,  14, -17 },
                {  -1,   2, -10,   0,  11 },
                {   6, -18,   0,  19,  16 }
            };

            DataService ds = new DataService();
            int[,] result = ds.Calculate(matrix);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
