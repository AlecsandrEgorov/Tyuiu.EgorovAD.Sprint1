using Tyuiu.EgorovAD.Sprint1.Task1.V24.Lib;
namespace Tyuiu.EgorovAD.Sprint1.Task1.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-0.75, res);
        }
    }
}
