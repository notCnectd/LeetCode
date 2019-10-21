// 503. Next Greater Element II

using System.Collections.Generic;

namespace LeetCodeDemo.Medium
{
    class Next_Greater_Element_II
    {
        public int[] NextGreaterElements(int[] nums)
        {
            Stack<int> stack = new Stack<int>();
            int len = nums.Length;
            int[] res = new int[len];
            for(int i = len * 2 - 1; i >= 0; i--)
            {
                while (stack.Count != 0 && stack.Peek() <= nums[i % len]) stack.Pop();
                res[i % len] = stack.Count == 0 ? -1 : stack.Peek();
                stack.Push(nums[i % len]);
            }
            return res;
        }
    }
}
