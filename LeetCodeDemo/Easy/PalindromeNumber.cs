using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Determine whether an integer is a palindrome.
// An integer is a palindrome when it reads the same backward as forward.
// Example 1:
    // Input: 121
    // Output: true
// Example 2:
    // Input: -121
    // Output: false
    // Explanation: From left to right, it reads -121. From right to left, it becomes 121-.
    // Therefore it is not a palindrome.
// Example 3:
    // Input: 10
    // Output: false
    // Explanation: Reads 01 from right to left.Therefore it is not a palindrome.

namespace LeetCodeDemo.Easy
{
    class PalindromeNumber
    {
        public static bool IsPalindrome1(int x)
        {
            
            string reverse = "";
            for (int i = x.ToString().Length - 1; i >= 0; i--)
            {
                reverse += x.ToString()[i];
            }         
            return reverse.Equals(x.ToString());
        }

        public static bool IsPalindrome2(int x)
        {
            if (x < 0) return false;
            long reverse = 0L;
            int copyOfX = x;
            int temp = 0;
            while (x != 0)
            {
                reverse = reverse * 10 + x % 10;
                x /= 10;
            }

            return (copyOfX == reverse) ? true : false;
        }
    }
}
