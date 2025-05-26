using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Tyuiu.NovikovD.Sprint3.Task7.V15.Lib;

namespace Tyuiu.NovikovD.Sprint3.Task7.V15.Test
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
                {-5, Math.Round(Math.Sin(-5) + (2 * -5) / 3 - Math.Cos(-5) * 4 * -5, 2)},
                {-4, Math.Round(Math.Sin(-4) + (2 * -4) / 3 - Math.Cos(-4) * 4 * -4, 2)},
                {-3, Math.Round(Math.Sin(-3) + (2 * -3) / 3 - Math.Cos(-3) * 4 * -3, 2)},
                {-2, Math.Round(Math.Sin(-2) + (2 * -2) / 3 - Math.Cos(-2) * 4 * -2, 2)},
                {-1, Math.Round(Math.Sin(-1) + (2 * -1) / 3 - Math.Cos(-1) * 4 * -1, 2)},
                {0, Math.Round(Math.Sin(0) + (2 * 0) / 3 - Math.Cos(0) * 4 * 0, 2)},
                {1, Math.Round(Math.Sin(1) + (2 * 1) / 3 - Math.Cos(1) * 4 * 1, 2)},
                {2, Math.Round(Math.Sin(2) + (2 * 2) / 3 - Math.Cos(2) * 4 * 2, 2)},
                {3, Math.Round(Math.Sin(3) + (2 * 3) / 3 - Math.Cos(3) * 4 * 3, 2)},
                {4, Math.Round(Math.Sin(4) + (2 * 4) / 3 - Math.Cos(4) * 4 * 4, 2)},
                {5, Math.Round(Math.Sin(5) + (2 * 5) / 3 - Math.Cos(5) * 4 * 5, 2)}
            };

            CollectionAssert.AreEqual(expected, res);
        }
    }
}
