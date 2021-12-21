using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IntegratingTest;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            [TestMethod]
            public void TestMethodSin() //Синус
            {
                Assert.AreEqual(Math.Round(Math.Sin(60 * Math.PI / 180), 4), Math.Round(IntegratingTest.Trigfunk.Trigfunk.Sin(60 * Math.PI / 180), 4));
            }

            [TestMethod]
            public void TestMethodCos() //Косинус
            {
                Assert.AreEqual(Math.Round(Math.Cos(60 * Math.PI / 180), 4), Math.Round(IntegratingTest.Trigfunk.Trigfunk.Cos(60 * Math.PI / 180), 4));
            }

            [TestMethod]
            public void TestMethodAbs() //Модуль
            {
                Assert.AreEqual(Math.Abs(-90), IntegratingTest.Trigfunk.Trigfunk.Abs(-90));
            }

            [TestMethod]
            public void TestMethodPower() //Возведение в степень
            {
                Assert.AreEqual(Math.Pow(5, 2), IntegratingTest.Trigfunk.Trigfunk.Power(5, 2));
            }

            [TestMethod]
            public void TestMethodTan() //Тангенс
            {
                Assert.AreEqual(Math.Round(Math.Tan(60 * Math.PI / 180), 4), Math.Round(IntegratingTest.Trigfunk.Trigfunk.Tan(60 * Math.PI / 180), 4));
            }

            [TestMethod]
            public void TestMethodCTan() //Котангенс
            {
                Assert.AreEqual(Math.Round(1 / Math.Tan(60 * Math.PI / 180), 4), Math.Round(IntegratingTest.Trigfunk.Trigfunk.Ctan(60 * Math.PI / 180), 4));
            }

            [TestMethod]
            public void TestMethodFactorial() //Факториал
            {
                Assert.AreEqual(120, IntegratingTest.Trigfunk.Trigfunk.Factorial(5));
            }

            [TestMethod]
            public void TestMethodSec() //Секонс
            {
                Assert.AreEqual(Math.Round(1 / Math.Cos(60 * Math.PI / 180), 4), Math.Round(IntegratingTest.Trigfunk.Trigfunk.sec(60 * Math.PI / 180), 4));
            }
        }
    }
}
