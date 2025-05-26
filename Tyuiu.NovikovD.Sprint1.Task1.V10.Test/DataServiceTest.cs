using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NovikovD.Sprint3.Task1.V7.Lib;

namespace Tyuiu.NovikovD.Sprint3.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculateSeriesProduct()
        {
            DataService ds = new DataService();
            double result = ds.CalculateSeriesProduct(0.25);
            double expected = 1;

            for (int k = 1; k <= 9; k++)
            {
                expected *= (Math.Pow(0.25, k) + 1) * Math.Sin(5);
            }

            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
