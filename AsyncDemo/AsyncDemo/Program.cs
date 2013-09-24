using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo
{
    static class MyExtensions
    {
        public static TaskAwaiter GetAwaiter(this TimeSpan t)
        {
            return Task.Delay(t).GetAwaiter();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Run();
            Console.Write("Wacht even");
            Console.ReadLine();

            // Op een multicore processor zullen de resultaten door elkaar lopen.
            var range = Enumerable.Range(0, 100);
            Parallel.ForEach(range, i => Console.WriteLine(i));

        }

        private static async void Run()
        {
            await TimeSpan.FromSeconds(5);
            
            Console.WriteLine();
            Console.Write("Klaar met wachten. Druk op Enter");
        }
    }
}
