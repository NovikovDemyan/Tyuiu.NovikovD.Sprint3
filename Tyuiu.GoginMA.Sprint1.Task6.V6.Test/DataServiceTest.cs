using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovikovD.Sprint1.Task6.V9.Lib;

namespace Tyuiu.NovikovD.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMoveLastLetter()
        {
            DataService ds = new DataService();
            string input = "Hello World";
            string result = ds.MoveLetterToStart(input);
            string wait = "oHell dWorl";
            Assert.AreEqual(wait, result);
        }
    }
}
