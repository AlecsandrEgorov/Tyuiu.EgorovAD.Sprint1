using Tyuiu.EgorovAD.Sprint1.Task5.V1.Lib;
namespace Tyuiu.EgorovAD.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x1 = 1;
            double x2 = 4;
            double y1 = 2;
            double y2 = 6;
            int wait = 5;
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            int result = Convert.ToInt32(res);
            Assert.AreEqual(wait, result);
        }
    }
}
