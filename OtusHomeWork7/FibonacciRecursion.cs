using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHomeWork7
{
    internal class FibonacciRecursion
    {
        public long CalculateFibbonacciRecursion(int n)
        {
            if ((n == 0) || (n == 1))
                return n;
            return CalculateFibbonacciRecursion(n - 1) + CalculateFibbonacciRecursion(n - 2);
        }
    }
}
