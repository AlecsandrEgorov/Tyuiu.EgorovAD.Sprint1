using Tyuiu.EgorovAD.Sprint1.Task7.V15.Lib;
namespace Tyuiu.EgorovAD.Sprint1.Task7.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double wait = 96.484;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
