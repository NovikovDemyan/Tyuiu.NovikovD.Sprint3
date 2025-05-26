using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NovikovD.Sprint2.Task3.V11.Lib;

namespace Tyuiu.NovikovD.Sprint2.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculatePositive()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(2);
            double expected = Math.Round(Math.Pow((2 + (2 - 15)) / (2 - 19), 2), 3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCalculateZero()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(0);
            double expected = Math.Round(Math.Pow(0, 2) - Math.Cos(0) + 10, 3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCalculateNegativeRange()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(-5);
            double expected = Math.Round(Math.Pow(-5, 2) - Math.Sin(Math.Pow(-5, 2)) + 12, 3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCalculateEdgeCase()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(-16);
            double expected = Math.Round(Math.Pow(1 + 1 / Math.Pow(-16, 2), 1.0 / -16), 3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCalculateBelowMinus20()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(-21);
            double expected = Math.Round(-21 + 10 * (1.0 / -21), 3);
            Assert.AreEqual(expected, result);
        }
    }
}
