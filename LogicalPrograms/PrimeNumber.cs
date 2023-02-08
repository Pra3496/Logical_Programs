using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        //Created prime numbers method
        public void PrimeNumbers(int number)
        {
            //Taking user input
            int count = 0;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("\n\tThe number is not prime");
                    count = 1;
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("\n\tThe number is prime");
            }
        }
    }
}
