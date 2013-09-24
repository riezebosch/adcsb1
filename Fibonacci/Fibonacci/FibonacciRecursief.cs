using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public static class FibonacciRecursief
    {
        public static int Bereken(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            if (n > 100)
            {
                throw new ArgumentOutOfRangeException("n");
            }

            return Bereken(n - 1) + Bereken(n - 2);
        }
    }
}
