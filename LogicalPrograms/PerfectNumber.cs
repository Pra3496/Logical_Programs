using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public void PerfectNo(int number)
        {

            int sum = 0, n;
            
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("\n\tIt is a perfect number"); 
            }
            else
            {
                Console.WriteLine("\n\tIt is a perfect number");               
            }
        }
    }
    
}
