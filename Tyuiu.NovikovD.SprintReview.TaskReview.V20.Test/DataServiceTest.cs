using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NovikovD.SprintReview.TaskReview.V20.Lib;

namespace Tyuiu.NovikovD.SprintReview.TaskReview.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateReviewFormula()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double y = 2.5;
            double result = ds.CalculateReviewFormula(x, y);
            double wait = 4.768;
            Assert.AreEqual(wait, result, 0.001);
        }
    }
}