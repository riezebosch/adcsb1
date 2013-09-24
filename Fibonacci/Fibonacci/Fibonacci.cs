using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public static class Fibonacci
    {
        public static IEnumerable<int> Reeks()
        {
            int a = 0;
            int b = 1;

            yield return a;
            yield return b;

            while (b < 100)
            {
                int temp = b;
                b = a + b;
                a = temp;

                yield return b;
            }
        }

        public static IEnumerable<int> FilterEven(IEnumerable<int> items)
        {
            foreach (var item in items)
            {
                if (item % 2 == 0)
                {
                    yield return item;
                }
            }
        }



        public static IEnumerable<int> Filter(IEnumerable<int> items, 
            FilterMethod method)
        {
            foreach (var item in items)
            {
                if (method(item))
                {
                    yield return item;
                }
            }
        }
    }

    public delegate bool FilterMethod(int item);

    
}
