using System;
using System.Linq;

namespace Benchmark.Core
{
    
    public class NaivePrime : IPrime
    {
        public bool IsPrime(int candidate)
        {
           if (candidate > 1)
            {
                return Enumerable
                    .Range(1, candidate)
                    .Where(x => candidate%x == 0)
                    .SequenceEqual(new[] {1, candidate});
            }
    
            return false;
        }
    }
    
}
