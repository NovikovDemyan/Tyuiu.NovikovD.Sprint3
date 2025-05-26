using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovikovD.Sprint1.Task2.V3.Lib;

namespace Tyuiu.NovikovD.Sprint1.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 3;
            var res = ds.ConvertHourToMin(x);
            Assert.AreEqual(180, res);
        }
    }
}
