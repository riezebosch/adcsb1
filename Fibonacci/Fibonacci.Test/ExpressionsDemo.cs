using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq.Expressions;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fibonacci.Test
{
    [TestClass]
    public class ExpressionsDemo
    {
        [TestMethod]
        public void TestExpression()
        {
            PrintA(i => i % 2 == 0);
            PrintB(i => i % 2 == 0);
        }

        private void PrintA(Func<int, bool> f)
        {
            Console.WriteLine(f);
        }

        private void PrintB(Expression<Func<int, bool>> f)
        {
            Console.WriteLine(f);
        }

        [TestMethod]
        public void TestEntityFrameworkExtensionMethods()
        {
            var entities = new AdventureWorks2012Entities();
            var allJohn = entities.People.
                Where(p => p.FirstName == "John").
                OrderBy(p => p.LastName, StringComparer.OrdinalIgnoreCase).
                Select(p => p.Password);

            var allJoh2 = from p in entities.People
                          where p.FirstName == "John"
                          orderby p.LastName
                          select p.Password;

        }
    }
}
