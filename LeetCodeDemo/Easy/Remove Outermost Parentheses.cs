using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Easy
{
    class Remove_Outermost_Parentheses
    {
        public string RemoveOuterParentheses(string S)
        {
            int left = 1, right = 0;
            string ans = "";
            for (int i = 1; i < S.Length; i++)
            {
                if (S[i] == '(') left++;
                else right++;
                if (left != right)
                    ans += S[i];
                else
                {
                    i++;
                    left = 1;
                    right = 0;
                }
            }
            return ans;
        }
    }
}
