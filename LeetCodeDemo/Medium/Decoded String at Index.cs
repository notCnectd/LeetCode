// 880.Decoded String at Index
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Medium
{
    class Decoded_String_at_Index
    {
        public static string DecodeAtIndex(string S, int K)
        {
            long len = 0;
            int i;
            for (i = 0; i < S.Length; i++)
            {
                if (S[i] >= 48 && S[i] <= 57)
                    len *= S[i] - 48;
                else len++;
            }
            long pos = K;
            for(i = S.Length - 1; i >= 0; i--)
            {
                pos %= len;
                if (pos == 0 && !(S[i] >= 48 && S[i] <= 57)) return S[i].ToString();
                if (S[i] >= 48 && S[i] <= 57) len /= S[i] - 48;
                else len--;
            }
            throw null;
        }
    }
}
