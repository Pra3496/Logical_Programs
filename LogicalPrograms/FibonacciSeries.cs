using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibonacciSeries
    {
        public void Fibonacci(int count)
        {
            int p1 = 0, p2 = 1, p3;
            Console.Write(p1 + " " + p2);
            for (int i = 1; i < count; i++)
            {
                p3 = p1 + p2;
                Console.Write(" " + p3);
                p1 = p2;
                p2 = p3;
            }
        }
    }
}
