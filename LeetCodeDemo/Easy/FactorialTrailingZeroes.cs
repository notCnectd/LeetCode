using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Easy
{
    class FactorialTrailingZeroes
    {
        public static int TrailingZeroes(int n)
        {          
            return (n == 0) ? 0 : n / 5 + TrailingZeroes(n / 5);
        }

        public static int nonTrailingZeroes(int n)
        {
            if (n < 5) return 0;
            
            int result = 0;
            while (n >= 5)
            {
                result += n / 5;
                n /= 5;                              
            }

            return result;
        }
    }
}
