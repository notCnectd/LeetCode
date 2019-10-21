using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Given a 32-bit signed integer, reverse digits of an integer.
//Example 1:
    //Input: 123
    //Output: 321
//Example 2:
    //Input: -123
    //Output: -321
//Example 3:
    //Input: 120
    //Output: 21
namespace LeetCodeDemo.Easy
{
    class Reverse
    {
        public static int ReverseInteger(int x)
        {
            int numOfDigits = 0;
            int newX = 0;
            bool isNegative = false;
            if (x < 0)
            {
                newX = -x;
                isNegative = true;
            }
            else
            {
                newX = x;
            }

            ArrayList arrX = new ArrayList();
            while (newX / 10 != 0)
            {
                arrX.Add(newX % 10);
                newX /= 10;
                numOfDigits++;
            }
            arrX.Add(newX);
            int result = 0;
            for (int i = 0; i < arrX.Count; i++)
            {
                if (numOfDigits >= 0)
                {
                    try
                    {
                        result = checked(result + (int)arrX[i] * (int)Math.Pow(10, numOfDigits));
                        numOfDigits--;
                    }
                    catch (Exception)
                    {
                        return 0;
                    }
                   
                }
            }
            return (isNegative) ? -result : result;
        }
    }
}
