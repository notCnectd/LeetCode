// 20.Valid Parentheses

using System.Collections.Generic;

namespace LeetCodeDemo.Easy
{
    class Valid_Parentheses
    {
        public static bool IsValid(string s)
        {
            if (s == null) return true;
            Stack<char> stack = new Stack<char>();
            foreach(char ch in s)
            {
                if (stack.Count > s.Length / 2) return false;
                if(ch == '(' || ch == '{' || ch == '[') stack.Push(ch);              
                if (ch == ')')
                {
                    if (stack.Count != 0 && stack.Peek() == '(') stack.Pop();
                    else return false;
                }
                if (ch == ']')
                {
                    if (stack.Count != 0 && stack.Peek() == '[') stack.Pop();
                    else return false;
                }
                if (ch == '}')
                {
                    if (stack.Count != 0 && stack.Peek() == '{') stack.Pop();
                    else return false;
                }
            }
            return stack.Count == 0 ? true : false;
        }
    }
}
