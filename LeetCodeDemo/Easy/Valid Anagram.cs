// 242. Valid Anagram
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Easy
{
    class Valid_Anagram
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            char[] char_t = new char[t.Length];
            char[] char_s = new char[s.Length];
            for (int i = 0; i < t.Length; i++)
            {
                char_t[i] = t[i];
                char_s[i] = s[i];
            }
            Array.Sort(char_t);
            Array.Sort(char_s);
            for(int i = 0; i < char_t.Length; i++)
            {
                if (char_t[i] != char_s[i]) return false;
            }
            return true;
        }

    }
}
