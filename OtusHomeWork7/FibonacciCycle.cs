using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHomeWork7
{
    internal class FibonacciCycle
    {
        public long CalculateFibonacciCycle(int n)
        {
            if (n == 0) return 0;
            int prev = 0;
            int next = 1;
            for (int i = 1; i < n; i++)
            {
                int sum = prev + next;
                prev = next;
                next = sum;
            }
            return next;
        }
    }
}
