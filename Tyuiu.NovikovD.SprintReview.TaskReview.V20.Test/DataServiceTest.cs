using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NovikovD.Sprint2.SprintReview.V3.Lib;

namespace Tyuiu.NovikovD.Sprint2.SprintReview.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestPointInside()
        {
            var ds = new DataService();
            Assert.IsTrue(ds.IsPointInShadedArea(0, 1));
        }

        [TestMethod]
        public void TestPointOutsideCircle()
        {
            var ds = new DataService();
            Assert.IsFalse(ds.IsPointInShadedArea(0, 3));
        }

        [TestMethod]
        public void TestPointUnderParabola()
        {
            var ds = new DataService();
            Assert.IsFalse(ds.IsPointInShadedArea(0.5, 0));
        }
    }
}
