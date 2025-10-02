using Tyuiu.EgorovAD.Sprint1.Task2.V10.Lib;
namespace Tyuiu.EgorovAD.Sprint1.Task2.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.ConvertMetreToInchs(x);
            Assert.AreEqual(39.37, res);   

        }
    }
}
