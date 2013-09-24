using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Fibonacci
{
    [TestClass]
    public class IEnumerableDemo
    {
       

        [TestMethod]
        public void TestMethod1()
        {
            var fib = FibonacciOld.Reeks().GetEnumerator();
            fib.MoveNext();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(fib.Current);
                fib.MoveNext();
            }
        }

        [TestMethod]
        public void Test0()
        {
            var fib = FibonacciOld.Reeks().GetEnumerator();
            Assert.AreEqual(0, fib.Current);
        }

        [TestMethod]
        public void Test1()
        {
            var fib = FibonacciOld.Reeks().GetEnumerator();
            fib.MoveNext();

            Assert.AreEqual(1, fib.Current);
        }

        [TestMethod]
        public void Test2()
        {
            var fib = FibonacciOld.Reeks().GetEnumerator();
            fib.MoveNext();
            fib.MoveNext();

            Assert.AreEqual(1, fib.Current);
        }

        [TestMethod]
        public void Test3()
        {
            var fib = FibonacciOld.Reeks().GetEnumerator();
            fib.MoveNext();
            fib.MoveNext();
            fib.MoveNext();

            Assert.AreEqual(2, fib.Current);
        }

        [TestMethod]
        public void TestForeach()
        {
            var lijstje = new List<int> { 2, 4, 3423, 43, 23, 43, 23, 3 };
            foreach (var item in lijstje)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void TestFib2()
        {
            foreach (var item in FibonacciOld.Reeks())
            {
                Console.WriteLine(item);
            }
        }
    }
}
