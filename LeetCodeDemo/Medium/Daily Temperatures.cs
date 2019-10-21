using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Medium
{
    class Daily_Temperatures
    {
        public static int[] DailyTemperatures(int[] T)
        {
            int[] ans = new int[T.Length];
            Stack<int> stack = new Stack<int>();
            
            for(int i = T.Length - 1; i >= 0; i--)
            {
                while (stack.Count != 0 && T[stack.Peek()] <= T[i]) stack.Pop();
                ans[i] = stack.Count == 0 ? 0 : stack.Peek() - i;
                stack.Push(i);
            }
            return ans;
        }
    }
}
