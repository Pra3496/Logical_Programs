using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public int ReverseNum(int number)
        {
            int reverse = 0;
            
            while (number != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + number % 10;
                number = number / 10;
            }
            return reverse;

        }
 
    }
}
