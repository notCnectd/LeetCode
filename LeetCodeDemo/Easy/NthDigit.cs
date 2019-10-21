// 400.Nth Digit
// Find the nth digit of the infinite integer sequence 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, ...

// Note:
// n is positive and will fit within the range of a 32-bit signed integer(n < 2^31).

// Example 1:
// Input:
// 3
// Output:
// 3
// Example 2:
// Input:
// 11
// Output:
// 0
// Explanation:
// The 11th digit of the sequence 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, ... is a 0,
// which is part of the number 10.

using System;

namespace LeetCodeDemo.Easy
{   
    class NthDigit
    {
        // 1  1-9：9 * 1
        // 2  10-99：90 * 2
        // 3  100-999：900 * 3
        // 4  1000-9999：9000 * 4
        // ...
        // 
        // 1, 11, 111, 1111, ...
        // 79
        public static int FindNthDigit(int n)
        {
            if (n <= 9) return n;
            int len = 0, result = 0, left = 0;
            for (; len < 10;)
            {
                try
                {
                    checked
                    {
                        left = n - result;
                        result += (int) Math.Pow(10, len) * 9 * (len + 1);                       
                        if (result == n)
                        {
                            return 9;
                        }
                        if(result > n)
                        {
                            break;
                        }
                        len++;
                    }
                }
                catch (Exception)
                {
                    break;
                }
            }

            int move = left / (len + 1);
            int moveOfNum = left % (len + 1);
            int resultNum;
            if (moveOfNum == 0)
            {
                resultNum = (int) Math.Pow(10, len) + move - 1;
                return resultNum % 10;
            }

            resultNum = (int) Math.Pow(10, len) + move;
            return resultNum.ToString()[moveOfNum - 1] - 48;
        }
    }
}
