using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Easy
{
    class LengthofLastWord
    {
        public static int LengthOfLastWord(string s)
        {
            int num = 0; int p = 0;
            for (int i = s.Length - 1; i>=0; i--)
            {
                if (s[i] == ' ') p++;
                else break;
            }
            for(int i = s.Length - 1 - p; i >= 0; i--)
            {
                if (s[i] != ' ') num++;
                else break;
            }
            return num;
        }
    }
}
