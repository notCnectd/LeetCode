// . Repeated Substring Pattern

namespace LeetCodeDemo.Easy
{
    class Repeated_Substring_Pattern
    {
        //public bool RepeatedSubstringPattern(string s)
        //{
        //    int size = s.Length;
        //    for (int i = 1; i <= size / 2; i++)
        //    {
        //        if (size % i == 0)
        //        {
        //            bool flag = true;
        //            for (int j = 0, k = i; k < size; j++, k++)
        //            {
        //                if (s[j] != s[k])
        //                {
        //                    flag = false;
        //                    break;
        //                }
        //            }
        //            if (flag) return true;
        //        }
        //    }
        //    return false;
        //}

        public bool RepeatedSubstringPattern(string s)
        {
            return new string((s + s).ToCharArray(), 1, s.Length * 2 -2).Contains(s);
        }
    }
}
