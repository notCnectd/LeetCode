// 970. Powerful Integers
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Easy
{
    class PowerfulIntegers
    {
        // brute force ！！！！！！！！！！！！
        public static IList<int> Powerful_Integers(int x, int y, int bound)
        {           
            List<int> result = new List<int>();
            if(x == 1 && y == 1)
            {
                if (bound >= 2) result.Add(2);
                return result;
            }
            if(x == 1)
            {
                for(int j = 0; j <= Math.Log(bound, y); j++)
                {
                    result.Add(1 + (int)Math.Pow(y, j));
                }
                return result;
            }
            if (y == 1)
            {
                for (int i = 0; i <= Math.Log(bound, x); i++)
                {
                    result.Add(1 + (int)Math.Pow(x, i));
                }
                return result;
            }
            for (int i = 0; i <= Math.Log(bound, x); i++)
            {
                for (int j = 0; j <= Math.Log(bound, y); j++)
                {
                    int candidate = (int)(Math.Pow(x, i) + Math.Pow(y, j));
                    if (candidate <= bound && !result.Contains(candidate)) result.Add(candidate);
                }
            }
            return result;
        }
    }
}
