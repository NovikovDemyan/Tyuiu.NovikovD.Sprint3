using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovikovD.Sprint1.Task5.V4.Lib;

namespace Tyuiu.NovikovD.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateHours()
        {
            DataService ds = new DataService();
            int seconds = 13257;
            int result = ds.CalculateHours(seconds);
            int wait = 3; // 13257 / 3600 = 3.6825  3 часа
            Assert.AreEqual(wait, result);
        }
    }
}
