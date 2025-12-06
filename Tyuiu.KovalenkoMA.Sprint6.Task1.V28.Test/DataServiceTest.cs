using Tyuiu.KovalenkoMA.Sprint6.Task1.V28.Lib;
namespace Tyuiu.KovalenkoMA.Sprint6.Task1.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            double[] res = ds.GetMassFunction(-5, 5);

            double[] wait = { 4.67, 0.43 , -8.26, -9.87, -3.98, 1, 0.02, -1.87, 3.74, 16.43, 24.67 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
