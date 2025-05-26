using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NovikovD.Sprint2.Task7.V8.Lib;

namespace Tyuiu.NovikovD.Sprint2.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestPointInsideArea()
        {
            var ds = new DataService();
            Assert.IsTrue(ds.CheckDotInShadedArea(1, 2));
        }

        [TestMethod]
        public void TestPointOutsideArea()
        {
            var ds = new DataService();
            Assert.IsFalse(ds.CheckDotInShadedArea(-1, 2));
        }

        [TestMethod]
        public void TestPointOnBorder()
        {
            var ds = new DataService();
            Assert.IsTrue(ds.CheckDotInShadedArea(2, 4)); // на границе
        }
    }
}
