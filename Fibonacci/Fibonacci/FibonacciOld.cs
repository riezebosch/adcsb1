using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public static class FibonacciOld
    {
        private class FibEnumerator : IEnumerator<int>
        {
            private int _previous;
            public int Current
            {
                get;
                private set;
            }

            public void Dispose()
            {
            }

            object System.Collections.IEnumerator.Current
            {
                get { return Current; }
            }

            public bool MoveNext()
            {
                if (Current < 1)
                {
                    Current++;
                }
                else
                {
                    int temp = Current;
                    Current = _previous + Current;
                    _previous = temp;
                }

                return true;
            }

            public void Reset()
            {
                Current = -1;
                _previous = 0;
            }
        }


        private class FibEnumerable : IEnumerable<int>
        {
            public IEnumerator<int> GetEnumerator()
            {
                return new FibEnumerator();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }
        }

        public static IEnumerable<int> Reeks()
        {
            return new FibEnumerable();
        }
    }
}
