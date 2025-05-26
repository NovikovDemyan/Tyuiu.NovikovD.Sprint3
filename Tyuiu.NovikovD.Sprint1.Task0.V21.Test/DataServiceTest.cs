using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NovikovD.Sprint2.Task0.V11.Lib;

namespace Tyuiu.NovikovD.Sprint2.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 8105;
            int y = 275;
            bool[] res = ds.GetCompareOperations(x, y);
            bool[] wait = { true, false, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}