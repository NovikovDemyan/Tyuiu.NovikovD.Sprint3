using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NovikovD.Sprint2.Task1.V5.Lib;

namespace Tyuiu.NovikovD.Sprint2.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 154;
            int b = 163;
            int c = 134;
            int d = 137;
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = { true, false, false, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}