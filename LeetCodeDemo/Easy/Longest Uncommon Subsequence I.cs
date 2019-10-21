// 521. Longest Uncommon Subsequence I
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Easy
{
    class Longest_Uncommon_Subsequence_I
    {
        public int FindLUSlength(string a, string b)
        {
            if (a == b) return -1;
            return a.Length < b.Length ? b.Length : a.Length;
        }
    }
}
