using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NovikovD.Sprint3.Task5.V29.Lib;

namespace Tyuiu.NovikovD.Sprint3.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateFunction()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.CalculateFunction(x);
            double expected = 2 * (1 + 1 / 2.0 + 1 / 3.0 + 1 / 4.0 + 1 / 5.0 + 1 / 6.0 + 1 / 7.0 + 1 / 8.0 + 1 / 9.0 + 1 / 10.0) * 3 + Math.Sin(2);

            Assert.AreEqual(expected, res, 0.001);
        }
    }
}
