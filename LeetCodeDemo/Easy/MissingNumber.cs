// Given an array containing n distinct numbers taken from 0, 1, 2, ..., n,
// find the one that is missing from the array.

// Example 1:
//  Input: [3,0,1]
//  Output: 

// Example 2:
//  Input: [9,6,4,2,3,5,7,0,1]
//  Output: 8

// Your algorithm should run in linear runtime complexity.
// Could you implement it using only constant extra space complexity?

namespace LeetCodeDemo.Easy
{
    class MissingNumber
    {
        public static int MissingNum(int[] nums)
        {
            // This is the easiest solution
            // For another solutions:
            // One is sort the nums first, then corresponding to the subscript of the array
            // One is use bit operation
            int sum = nums.Length * (nums.Length + 1) / 2;
            for (int i = 0; i < nums.Length; i++)
            {
                sum -= nums[i];
            }
            return sum;
        }
    }
}
