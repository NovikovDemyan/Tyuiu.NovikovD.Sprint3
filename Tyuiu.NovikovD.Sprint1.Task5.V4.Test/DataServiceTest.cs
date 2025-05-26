using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NovikovD.Sprint2.Task5.V5.Lib;

namespace Tyuiu.NovikovD.Sprint2.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCardNameKing()
        {
            DataService ds = new DataService();
            string result = ds.FindCardValue(13);
            Assert.AreEqual("Король", result);
        }

        [TestMethod]
        public void TestCardNameSix()
        {
            DataService ds = new DataService();
            string result = ds.FindCardValue(6);
            Assert.AreEqual("Шестерка", result);
        }

        [TestMethod]
        public void TestInvalidCard()
        {
            DataService ds = new DataService();
            string result = ds.FindCardValue(15);
            Assert.AreEqual("Некорректный номер карты", result);
        }
    }
}
