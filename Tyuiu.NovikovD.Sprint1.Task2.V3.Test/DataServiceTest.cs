using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NovikovD.Sprint3.Task2.V14.Lib;

namespace Tyuiu.NovikovD.Sprint3.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculateProduct()
        {
            DataService ds = new DataService();
            double x = 5;

            double expected = 1;
            for (int k = 1; k <= 6; k++)
            {
                expected *= Math.Pow((x / k), 3);
            }

            double result = ds.CalculateProduct(x);

            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
