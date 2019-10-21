using System;

// Given an array of integers, return indices of the two numbers such that
// they add up to a specific target.
// You may assume that each input would have exactly one solution,
// and you may not use the same element twice.
// Example:
    // Given nums = [2, 7, 11, 15], target = 9,
    // Because nums[0] + nums[1] = 2 + 7 = 9, return [0, 1].


namespace LeetCodeDemo.Easy
{
    class TwoSum
    {
        public static int[] Two_Sum(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = target - nums[i];
                int num_j = Array.IndexOf(nums, temp, i);
                int num_k = 0;
                if (num_j == -1) { continue; }
                if (num_j == i && (num_k = Array.IndexOf(nums, temp, i + 1)) != -1)
                {
                    result[0] = i;
                    result[1] = num_k;
                    return result;
                }
                if (num_j != i)
                {
                    result[0] = i;
                    result[1] = num_j;
                    return result;
                }
            }
            return result;
        }
    }
}
