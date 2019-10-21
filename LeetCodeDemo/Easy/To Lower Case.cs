// 709. To Lower Case

namespace LeetCodeDemo.Easy
{
    class To_Lower_Case
    {
        public static string ToLowerCase(string str)
        {
            string res = "";
            char[] ch = str.ToCharArray();
            for(int i = 0; i < ch.Length; i++)
            {
                if (ch[i] <= 'Z' && ch[i] >= 'A') ch[i] = (char)(ch[i] + 32);
                res += ch[i];
            }
            return res;
        }
    }
}
