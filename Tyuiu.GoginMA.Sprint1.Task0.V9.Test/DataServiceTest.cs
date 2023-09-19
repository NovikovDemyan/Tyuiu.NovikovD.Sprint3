using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoginMA.Sprint1.Task0.V9.Lib;

namespace Tyuiu.GoginMA.Sprint1.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(3, res);
        }
    }
}
