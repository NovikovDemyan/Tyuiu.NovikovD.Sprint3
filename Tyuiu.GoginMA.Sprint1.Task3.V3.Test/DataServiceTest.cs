using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoginMA.Sprint1.Task3.V3.Lib;

namespace Tyuiu.GoginMA.Sprint1.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double length = 1;
            double width = 2;
            double height = 3;
            double Volume = 6;
            var res = ds.ParallelepipedVolume(length, width, height);
            Assert.AreEqual(Volume, res);
        }
    }
}
