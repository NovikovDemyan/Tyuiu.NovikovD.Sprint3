using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovikovD.Sprint1.Task4.V24.Lib;

namespace Tyuiu.NovikovD.Sprint1.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.5;
            double y = 1.5;
            double result = ds.Calculate(x, y);
            double wait = 0.234; // Примерное значение для проверки
            Assert.AreEqual(wait, result);
        }
    }
}
