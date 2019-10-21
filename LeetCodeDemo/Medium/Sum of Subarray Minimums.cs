// 907. Sum of Subarray Minimums

using System.Collections.Generic;

namespace LeetCodeDemo.Medium
{
    class Sum_of_Subarray_Minimums
    {
        public static int SumSubarrayMins(int[] A)
        {
            int size = A.Length;
            int MOD = 1_000_000_007;
            Stack<int> stack = new Stack<int>();
            int i = 0;
            int[] left, right;
            left = new int[size];
            for (; i < size; i++)
            {
                while (stack.Count != 0 && A[i] <= A[stack.Peek()])
                    stack.Pop();
                left[i] = stack.Count == 0 ? -1 : stack.Peek();
                stack.Push(i);
            }
            right = new int[size];
            stack = new Stack<int>();
            for(i = size - 1; i >= 0; i--)
            {
                while (stack.Count != 0 && A[i] < A[stack.Peek()])
                    stack.Pop();
                right[i] = stack.Count == 0 ? size : stack.Peek();
                stack.Push(i);
            }
            long res = 0;
            for(i = 0; i < size; i++)
            {
                res += A[i] % MOD * (i - left[i]) * (right[i] - i) % MOD;
                res %= MOD;
            }
            return (int)res;
        }
    }
}
