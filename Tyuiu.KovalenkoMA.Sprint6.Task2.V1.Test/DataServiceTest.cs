using Tyuiu.KovalenkoMA.Sprint6.Task2.V1.Lib;
namespace Tyuiu.KovalenkoMA.Sprint6.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double[] res = ds.GetMassFunction(-5, 5);

            double[] wait = { 20.36, 15.42, 10.99, 7.43, 4.33, 1, 0, -8.87, -13.03, -16.53, -19.6 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}