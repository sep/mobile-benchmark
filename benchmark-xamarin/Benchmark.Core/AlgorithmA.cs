using System;
using System.Linq;

namespace Benchmark.Core
{
    
    public class AlgorithmAMonoMath : IPrime
    {
        public bool IsPrime(int candidate)
        {
            if (candidate == 1) return false;
            if (candidate == 2) return true;
        
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(candidate)); ++i)  {
               if (candidate % i == 0)  return false;
            }
        
            return true;
        }
    }
}
