// 1047. Remove All Adjacent Duplicates In String
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Easy
{
    class Remove_All_Adjacent_Duplicates_In_String
    {
        public static string RemoveDuplicates(string S)
        {
            //Stack<char> stack = new Stack<char>();
            char[] stack = new char[S.Length];
            int top = -1;
            stack[++top] = S[0];
            for(int i = 1; i < S.Length; i++)
            {
                if (top == -1) stack[++top] = S[i];
                else if (S[i] == stack[top]) top--;
                else stack[++top] = S[i];
            }
            
            return string.Join("", stack).Remove(top + 1, S.Length - (top + 1)); 
        }
    }
}
