// 14. Longest Common Prefix
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Easy
{
    class LongestCommonPrefix
    {
        public static string Longest_CommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            string result = "";
            int shortest = strs[0].Length;
            int col, row;
            for(int i = 1; i < strs.Length; i++)
            {
                if (strs[i].Length < shortest) shortest = strs[i].Length;
            }

            for(col = 0; col < shortest; col++)
            {
                for(row = 1; row < strs.Length; row++)
                {
                    if (strs[row - 1][col] != strs[row][col]) break;
                }
                if (row == strs.Length) result += strs[0][col];
                else break;
            }
            return result;
        }
        // divide and conqure
    }
}
