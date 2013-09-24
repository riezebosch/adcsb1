using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Fibonacci
{
    [TestClass]
    public class YieldReturnDemo
    {
        

        [TestMethod]
        public void TestMethod1()
        {
            var fib = Fibonacci.Reeks().GetEnumerator();
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
            var fib = Fibonacci.Reeks().GetEnumerator();
            Assert.AreEqual(0, fib.Current);
        }

        [TestMethod]
        public void Test1()
        {
            var fib = Fibonacci.Reeks().GetEnumerator();
            fib.MoveNext();
            fib.MoveNext();

            Assert.AreEqual(1, fib.Current);
        }

        [TestMethod]
        public void Test2()
        {
            var fib = Fibonacci.Reeks().GetEnumerator();
            fib.MoveNext();
            fib.MoveNext();
            fib.MoveNext();

            Assert.AreEqual(1, fib.Current);
        }

        [TestMethod]
        public void Test3()
        {
            var fib = Fibonacci.Reeks().GetEnumerator();
            fib.MoveNext();
            fib.MoveNext();
            fib.MoveNext();
            fib.MoveNext();

            Assert.AreEqual(2, fib.Current);
        }

        [TestMethod]
        public void Twice()
        {

            foreach (var item in Fibonacci.Reeks())
            {
                Console.WriteLine(item);
            }

            foreach (var item in Fibonacci.Reeks())
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void TestFilterEven()
        {
            var items = Fibonacci.Reeks();
            var filter = Fibonacci.FilterEven(items);

            foreach (var item in filter)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void TestFilterDelegate()
        {
            var items = Fibonacci.Reeks();
            var filter = Fibonacci.Filter(items, IsEven);

            foreach (var item in filter)
            {
                Console.WriteLine(item);
            }
        }

        private bool IsEven(int item)
        {
            return item % 2 == 0;
        }
    }
}
