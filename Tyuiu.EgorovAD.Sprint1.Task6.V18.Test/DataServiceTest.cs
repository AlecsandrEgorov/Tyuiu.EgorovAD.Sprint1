using Tyuiu.EgorovAD.Sprint1.Task6.V18.Lib;
namespace Tyuiu.EgorovAD.Sprint1.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string str = "123";
            bool res = ds.CheckNumber(str);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
