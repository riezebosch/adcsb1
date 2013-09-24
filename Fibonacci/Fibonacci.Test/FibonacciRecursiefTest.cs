using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci.Test
{
    [TestClass]
    public class FibonacciRecursiefTest
    {
        [TestMethod]
        public void TestCase0()
        {
            var result = FibonacciRecursief.Bereken(0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestCase1()
        {
            var result = FibonacciRecursief.Bereken(1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestCase2()
        {
            var result = FibonacciRecursief.Bereken(2);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestCase3()
        {
            var result = FibonacciRecursief.Bereken(3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestCase4()
        {
            var result = FibonacciRecursief.Bereken(4);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestCase5()
        {
            var result = FibonacciRecursief.Bereken(5);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestCase100()
        {
            var result = FibonacciRecursief.Bereken(100);
            Assert.AreEqual(5, result);
        }
    }
}
