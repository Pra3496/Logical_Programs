using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class CouponNumber
    {
       

        public int CollectCoupons(int number)
        {
            int[] coupons = new int[number];
            int count = 0;
            int unique = 0;
            Random rand = new Random();
            while (unique < number)
            {
                
                int coupon = rand.Next(0, number);

                if (coupons[coupon] == 0)
                {
                    unique++;
                    coupons[coupon] = 1;
                }
                count++;
            }
            return count;
        }

    }
}
