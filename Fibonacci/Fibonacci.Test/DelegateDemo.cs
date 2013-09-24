using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci.Test
{
    delegate int NaamVanDeDelegate(double input, string nogwat, int doemaarwat);
    delegate TResult NaamVanDeDelegateMetGenerics<TResult, T1, T2, T3>(T1 input, T2 nogwat, T3 doemaarwat);
    
    [TestClass]
    public class DelegateDemo
    {
        [TestMethod]
        public void TestDelegate()
        {
            NaamVanDeDelegate instantie1 = new NaamVanDeDelegate(DezeMethodeVoldoetAanDeSignatuur);
            Execute(instantie1);

            NaamVanDeDelegate instantie2 = DezeMethodeVoldoetAanDeSignatuur;
            Execute(instantie2);

            Execute(DezeMethodeVoldoetAanDeSignatuur);

            NaamVanDeDelegateMetGenerics<int, double, string, int> instantie3 = DezeMethodeVoldoetAanDeSignatuur;
            Func<double, string, int, int> instantie4 = DezeMethodeVoldoetAanDeSignatuur;

            Execute((double a, string b, int c) => 4);
        }

        private void Execute(NaamVanDeDelegate f)
        {
            f.Invoke(34, "mijn naam", 1);
            f(34, "mijn naam", 1);
        }

        private void Execute2(Func<double, string, int, int> f)
        {
            f.Invoke(34, "mijn naam", 1);
            f(34, "mijn naam", 1);
        }


        private int DezeMethodeVoldoetAanDeSignatuur(double input, string maaktnietuit, int alsdeparametersmaarovereenkomen)
        {
            return 4;
        }
    }
}
