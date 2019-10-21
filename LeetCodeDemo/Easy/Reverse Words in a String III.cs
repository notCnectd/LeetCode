// 557. Reverse Words in a String III

namespace LeetCodeDemo.Easy
{
    class Reverse_Words_in_a_String_III
    {
        public static string ReverseWords(string s)
        {
            string res = "";
            string[] strs = s.Split();
            for (int i = 0; i < strs.Length; i++)
                strs[i] = Reverse(strs[i]);
            return string.Join(" ", strs);
       
        }

        public static string Reverse(string s)
        {
            char[] chs = s.ToCharArray();
            for (int i = 0, j = chs.Length - 1; i < j; i++, j--)
            {
                char tmp;
                tmp = chs[j];
                chs[j] = chs[i];
                chs[i] = tmp;
            }
            return new string(chs);
        }
    }
}
