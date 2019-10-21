// 344.Reverse_String

namespace LeetCodeDemo.Easy
{
    class Reverse_String
    {
        public void ReverseString(char[] s)
        {
            int i = 0, j = s.Length - 1;
            char tmp;
            for(; i < j; i++, j--)
            {
                tmp = s[i];
                s[i] = s[j];
                s[j] = tmp;
            }
        }
    }
}
