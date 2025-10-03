using Tyuiu.EgorovAD.Sprint1.Task4.V17.Lib;
namespace Tyuiu.EgorovAD.Sprint1.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 14;
            double y = 2;
            double wait = 0.5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
