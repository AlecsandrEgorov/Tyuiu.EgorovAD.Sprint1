using System;
using System.Numerics;
using Tyuiu.EgorovAD.Sprint1.Task3.V16.Lib


namespace Tyuiu.EgorovAD.Sprint1.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 5;
            double x2 = 6;
            var res = ds.CoeffOfQuadraticEquation(x1, x2);
            Assert.AreEqual(-11, res);
        }
    }
}
