using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NovikovD.Sprint3.Task6.V24.Lib;
using System.Collections.Generic;

namespace Tyuiu.NovikovD.Sprint3.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCountDivisorsInRange()
        {
            DataService ds = new DataService();
            Dictionary<int, int> res = ds.CountDivisorsInRange(17, 26);
            Dictionary<int, int> expected = new Dictionary<int, int>
            {
                {17, 2}, {18, 6}, {19, 2}, {20, 6}, {21, 4}, {22, 4}, {23, 2}, {24, 8}, {25, 3}, {26, 4}
            };

            CollectionAssert.AreEqual(expected, res);
        }
    }
}
