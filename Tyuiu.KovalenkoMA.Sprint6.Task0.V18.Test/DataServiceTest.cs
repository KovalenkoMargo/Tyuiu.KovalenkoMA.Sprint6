using Tyuiu.KovalenkoMA.Sprint6.Task0.V18.Lib;
namespace Tyuiu.KovalenkoMA.Sprint6.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res1 = ds.Calculate(3);
            Assert.AreEqual(1.056, res1);
        }
    }
}
