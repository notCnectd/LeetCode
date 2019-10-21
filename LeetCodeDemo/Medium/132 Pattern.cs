// 456. 132 Pattern

using System;
using System.Collections.Generic;

namespace LeetCodeDemo.Medium
{
    class _132_Pattern
    {
        public bool Find132pattern(int[] nums)
        {
            if (nums.Length < 3) return false;
            int last = Int32.MinValue, temp;
            Stack<int> stack = new Stack<int>();
            stack.Push(nums[nums.Length - 1]);
            for(int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] < last) return true;
                while(stack.Count != 0 && nums[i] > stack.Peek())
                {
                    temp = stack.Pop();
                    last = temp > last ? temp : last;
                }
                stack.Push(nums[i]);
            }
            return false;
        }
    }
}
