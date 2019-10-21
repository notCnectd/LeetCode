// 946. Validate Stack Sequences

using System.Collections.Generic;

namespace LeetCodeDemo.Medium
{
    class Validate_Stack_Sequences
    {
        public static bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            int cur = 0, i = 0;
            Stack<int> stack = new Stack<int>();
            int[] res = new int[popped.Length];
            for (; i < pushed.Length;)
            {
                if (pushed[i] == popped[cur]) res[cur++] = pushed[i];
                else if(pushed[i] != popped[cur])
                {
                    if (stack.Count == 0 || stack.Peek() != popped[cur]) stack.Push(pushed[i]);
                    else
                    {
                        res[cur++] = stack.Pop();
                        continue;
                    }
                }
                i++;
            }
            i = cur;
            while(stack.Count != 0) res[i++] = stack.Pop();
            for(i = 0; i < res.Length; i++)
            {
                if (res[i] != popped[i]) return false;
            }
            return true;
        }
    }
}
