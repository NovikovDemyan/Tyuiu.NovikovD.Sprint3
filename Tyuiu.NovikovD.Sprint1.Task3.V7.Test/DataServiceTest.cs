using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovikovD.Sprint1.Task3.V7.Lib;

namespace Tyuiu.NovikovD.Sprint1.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double verst = 100;
            double result = ds.VerstsToKilometers(verst);
            double wait = 106.68;
            Assert.AreEqual(wait, result);
        }
    }
}
