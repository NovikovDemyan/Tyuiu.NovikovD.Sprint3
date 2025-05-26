using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NovikovD.Sprint3.Task0.V24.Lib;

namespace Tyuiu.NovikovD.Sprint3.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculateProductSeries()
        {
            DataService ds = new DataService();
            double actual = ds.CalculateProductSeries(5);
            double expected = 0.000; // Замените на точное значение, если нужно
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
