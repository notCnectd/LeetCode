// 202.HappyNumber
// Write an algorithm to determine if a number is "happy".

// A happy number is a number defined by the following process: Starting with any positive integer,
// replace the number by the sum of the squares of its digits,
// and repeat the process until the number equals 1 (where it will stay),
// or it loops endlessly in a cycle which does not include 1.
// Those numbers for which this process ends in 1 are happy numbers.

// Example: 
// Input: 19
// Output: true
// Explanation: 
// 12 + 92 = 82
// 82 + 22 = 68
// 62 + 82 = 100
// 12 + 02 + 02 = 1

using System.Collections.Generic;

namespace LeetCodeDemo.Easy
{
    class HappyNumber
    {
        // Unhappy numbers will definitely get into a circle:  4 → 16 → 37 → 58 → 89 → 145 → 42 → 20 → 4
        // But how to prove?
        public static bool IsHappy(int n)
        {
            if (n == 1) return true;
            List<int> exist = new List<int>();
            int temp;
            temp = compute(n);
            exist.Add(temp);
            while (true)
            {
                if (temp == 1) return true;
                temp = compute(temp);
                if (exist.Contains(temp)) return false;
                exist.Add(temp);
            }
        }

        public static int compute(int n)
        {
            if (n < 10 && n >= 0) return n * n;
            int temp;
            int result = 0;
            temp = n % 10;
            n /= 10;
            while (n > 0)
            {                
                result += temp * temp + (n % 10) * (n % 10);
                n /= 10;
                if (n >= 10)
                {
                    temp = n % 10;
                }
                temp = 0;
            }

            return result;
        }
    }
}
