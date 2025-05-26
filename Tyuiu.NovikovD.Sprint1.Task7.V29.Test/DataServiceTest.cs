using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovikovD.Sprint1.Task7.V29.Lib;

namespace Tyuiu.NovikovD.Sprint1.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            double result = ds.Calculate(x, y);
            double wait = 0.841; // Примерное значение для проверки
            Assert.AreEqual(wait, result, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidDenominatorTest()
        {
            DataService ds = new DataService();
            ds.Calculate(1.0, 3.0); // xy-3 = 0
        }
    }
}
