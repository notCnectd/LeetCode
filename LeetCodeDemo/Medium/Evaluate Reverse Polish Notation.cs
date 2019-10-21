// 150. Evaluate Reverse Polish Notation

using System.Collections.Generic;

namespace LeetCodeDemo.Medium
{
    class Evaluate_Reverse_Polish_Notation
    {
        public static int EvalRPN(string[] tokens)
        {
            int temp;
            Stack<int> stack = new Stack<int>();
            foreach (string str in tokens)
            {
                if (str == "+" || str == "-" || str == "*" || str == "/")
                {
                    temp = Cal(str, stack.Pop(), stack.Pop());
                    stack.Push(temp);                   
                }
                else stack.Push(int.Parse(str));
            }
            return stack.Pop();
        }

        public static int Cal(string op, int x, int y)
        {
            switch (op)
            {
                case "+": return x + y;
                case "-": return y - x;
                case "*": return x * y;
                case "/": return y / x;
                default:  return 0;                    
            }
        }
    }
}
