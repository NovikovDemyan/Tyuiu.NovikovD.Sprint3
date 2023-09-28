using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoginMA.Sprint1.Task6.V6.Lib;

namespace Tyuiu.GoginMA.Sprint1.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Даны три слова";
            DataService ds = new DataService();
            string res = ds.DeleteFirstLetter(strTest);
            string wait = "аны ри лова";
            Assert.AreEqual(wait, res);
        }
    }
}
