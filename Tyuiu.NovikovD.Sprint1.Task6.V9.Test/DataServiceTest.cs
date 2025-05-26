using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NovikovD.Sprint2.Task6.V3.Lib;

namespace Tyuiu.NovikovD.Sprint2.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMonday()
        {
            var ds = new DataService();
            string result = ds.FindDayName(1);
            Assert.AreEqual("Понедельник", result);
        }

        [TestMethod]
        public void TestInvalidDay()
        {
            var ds = new DataService();
            string result = ds.FindDayName(8);
            Assert.AreEqual("Ошибка: некорректный номер дня", result);
        }

        [TestMethod]
        public void TestSunday()
        {
            var ds = new DataService();
            string result = ds.FindDayName(7);
            Assert.AreEqual("Воскресенье", result);
        }
    }
}
