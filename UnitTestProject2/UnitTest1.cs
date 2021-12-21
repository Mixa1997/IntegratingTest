using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IntegratingTest;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodLn() //Натуральный логарифм
        {
            int x = 0;
            Assert.AreEqual(Math.Round(Math.Log(1 - x), 0), Math.Round(IntegratingTest.Trigfunk.Trigfunk.Ln(x), 0));
        }
    }
}
