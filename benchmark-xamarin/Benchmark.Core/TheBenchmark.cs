using System;

namespace Benchmark.Core
{
    public static class TheBenchmark
    {
        public static TimeSpan Timed(Action toPerform)
        {
            var begin = DateTime.Now;
            toPerform ();
            var end = DateTime.Now;
            
            return end - begin;
        }
    }
}
