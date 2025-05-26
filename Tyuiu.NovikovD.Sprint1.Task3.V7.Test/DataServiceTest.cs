using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NovikovD.Sprint3.Task3.V7.Lib;

namespace Tyuiu.NovikovD.Sprint3.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestReplaceGWith4()
        {
            DataService ds = new DataService();
            string input = "gft hggt ntg";
            string expected = "4ft h44t nt4";
            string result = ds.ReplaceGWith4(input);

            Assert.AreEqual(expected, result);
        }
    }
}
