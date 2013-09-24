using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci.Test
{
    [TestClass]
    public class AnonymousMethodDemo
    {
        [TestMethod]
        public void TestMethod1()
        {
            Execute(FuncVoorbeeld);
            Execute(delegate(int input) { return " Inline delegate " + input; });
            Execute((int input) => { return "Lambda voorbeeld" + input; });
            Execute((int input) => "Lambda voorbeeld" + input);
            Execute(input => "Lambda voorbeeld" + input);

            var filtered = new[] { 1, 43, 23, 23, 23, 523452345, 234, 234 }
                .Where(item => item % 2 == 0);

            Execute2(3, (item1, item2) => true);
            
        }

        private static string FuncVoorbeeld(int input)
        {
            return input.ToString() + " FuncVoorbeeld";
        }

        void Execute(Func<int, string> f)
        {
            string result = f(5);
            Console.WriteLine(result);
        }

        void Execute2(int a, Func<int, double, bool> f)
        {
        }
    }
}
