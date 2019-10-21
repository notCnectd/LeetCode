// 28. Implement strStr()
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Easy
{
    class Implement_strStr__
    {
        public static int StrStr(string haystack, string needle)
        {
            int haystackLen = haystack.Length;
            int needleLen = needle.Length;
            if (needleLen == 0) return 0;
            if (haystackLen < needleLen) return -1;
            int max = haystackLen - needleLen;
            char first = needle[0];
            for (int i = 0; i <= max; i++)
            {
                if (haystack[i] != first)
                {
                    while (++i <= max && haystack[i] != first) ;
                }                   
                if (i <= max)
                {
                    int j = i + 1;
                    int end = j + needleLen - 1;
                    for (int k = 1; j < end && needle[k] == haystack[j]; j++, k++) ;
                    if (j == end) return i;
                }
            }
            return -1;
        }
    }
}
