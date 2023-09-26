using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoginMA.Sprint1.Task4.V13.Lib;

namespace Tyuiu.GoginMA.Sprint1.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = -0.045;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
