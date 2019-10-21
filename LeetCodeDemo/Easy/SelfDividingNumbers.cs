// 728.Self Dividing Numbers

// A self-dividing number is a number that is divisible by every digit it contains.
// For example, 128 is a self-dividing number because 128 % 1 == 0, 128 % 2 == 0, and 128 % 8 == 0.
// Also, a self-dividing number is not allowed to contain the digit zero.
// Given a lower and upper number bound, output a list of every possible self dividing number,
// including the bounds if possible.

// Example 1:
//  Input: 
//  left = 1, right = 22
//  Output: [1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22]

// Note:
//   The boundaries of each input argument are 1 <= left <= right <= 10000.

using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace LeetCodeDemo.Easy
{
    class SelfDividingNumbers
    {
        //public static IList<int> Self_Dividing_Numbers(int left, int right)
        //{
        //    IList<int> result = new List<int>();
        //    for (int i = left; i <= right; i++)
        //    {
        //        result.Add(i);
        //        string num_str = i.ToString();
        //        for (int j = 0; j < num_str.Length; j++)
        //        {                  
        //            if (num_str[j] == '0' || i % (num_str[j] - 48) != 0)
        //            {
        //                result.Remove(i);
        //                break;
        //            }      
        //        }
        //    }
        //    return result;
        //}

        public static IList<int> NewSolution(int left, int right) 
        {
            IList<int> result = new List<int>();
            for (int i = left; i <= right; i++)
            {
                result.Add(i);
                int temp = i;
                while (temp != 0)
                {
                    if (temp % 10 == 0 || i % (temp % 10) != 0) 
                    {
                        result.Remove(i);
                        break;
                    }
                    temp /= 10;
                }   
            }
            return result;
        }

    }
}
