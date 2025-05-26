using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Tyuiu.NovikovD.Sprint3.SprintReview.V13.Lib;

namespace Tyuiu.NovikovD.Sprint3.SprintReview.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidTabulateFunction()
        {
            DataService ds = new DataService();
            Dictionary<double, double> res = ds.TabulateFunction(-5, 5, 1);
            Dictionary<double, double> expected = new Dictionary<double, double>
            {
                {-5, Math.Round(3 * -5 + 2 - (2 * -5 - -5) / (Math.Cos(-5) + 1), 2)},
                {-4, Math.Round(3 * -4 + 2 - (2 * -4 - -4) / (Math.Cos(-4) + 1), 2)},
                {-3, Math.Round(3 * -3 + 2 - (2 * -3 - -3) / (Math.Cos(-3) + 1), 2)},
                {-2, Math.Round(3 * -2 + 2 - (2 * -2 - -2) / (Math.Cos(-2) + 1), 2)},
                {-1, Math.Round(3 * -1 + 2 - (2 * -1 - -1) / (Math.Cos(-1) + 1), 2)},
                {0, Math.Round(3 * 0 + 2 - (2 * 0 - 0) / (Math.Cos(0) + 1), 2)},
                {1, Math.Round(3 * 1 + 2 - (2 * 1 - 1) / (Math.Cos(1) + 1), 2)},
                {2, Math.Round(3 * 2 + 2 - (2 * 2 - 2) / (Math.Cos(2) + 1), 2)},
                {3, Math.Round(3 * 3 + 2 - (2 * 3 - 3) / (Math.Cos(3) + 1), 2)},
                {4, Math.Round(3 * 4 + 2 - (2 * 4 - 4) / (Math.Cos(4) + 1), 2)},
                {5, Math.Round(3 * 5 + 2 - (2 * 5 - 5) / (Math.Cos(5) + 1), 2)}
            };

            CollectionAssert.AreEqual(expected, res);
        }
    }
}
