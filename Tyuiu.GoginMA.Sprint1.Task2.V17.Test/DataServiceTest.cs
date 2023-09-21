using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoginMA.Sprint1.Task2.V17.Lib;

namespace Tyuiu.GoginMA.Sprint1.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 60;
            var res = ds.ConvertMinutesToHours(x);
            Assert.AreEqual(1, res);
        }
    }
}
