using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NovikovD.Sprint3.Task4.V8.Lib;

namespace Tyuiu.NovikovD.Sprint3.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            double res = ds.Calculate(start, stop);
            double wait = -0.031; // Ожидаемый результат округленный до 3 знаков
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}