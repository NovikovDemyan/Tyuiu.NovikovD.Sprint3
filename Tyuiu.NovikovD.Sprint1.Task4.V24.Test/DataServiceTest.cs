using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NovikovD.Sprint2.Task4.V14.Lib;

namespace Tyuiu.NovikovD.Sprint2.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculateTrueCondition()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 9;
            double expected = Math.Round((2 + (1 / x)) * y, 3);
            double result = ds.Calculate(x, y);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCalculateFalseCondition()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 3;
            double numerator = Math.Pow(y, 2) - Math.Cos(Math.Pow(x, 2)) + 10;
            double denominator = Math.Pow(x, 2) - Math.Sin(Math.Pow(y, 2)) + 12;
            double expected = Math.Round(numerator / denominator, 3);
            double result = ds.Calculate(x, y);
            Assert.AreEqual(expected, result);
        }
    }
}
