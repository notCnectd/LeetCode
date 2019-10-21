// 171. Excel Sheet Column Number
using System;

namespace LeetCodeDemo.Easy
{
    class ExcelSheetColumnNumber
    {
        public static int TitleToNumber(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                result += (int) (Math.Pow(26, s.Length - i - 1) * (s[i] - 64));
            }
            return result;
        }
    }
}
