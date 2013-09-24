using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAsyncRunnerDemo
{
    static class MyExtensions
    {
        public static TaskAwaiter<int> GetAwaiter(this Process p)
        {
            var tcs = new TaskCompletionSource<int>();
            if (p.HasExited)
            {
                tcs.SetResult(p.ExitCode);
            }
            else
            {
                p.EnableRaisingEvents = true;
                p.Exited += (s, e) => tcs.SetResult(p.ExitCode);
            }
            return tcs.Task.GetAwaiter();
        }
    }
}
