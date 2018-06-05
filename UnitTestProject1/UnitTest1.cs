using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "Hi, Peera";
            string actual = null;

            Assert.AreEqual(expected, actual);
        }
    }
}
