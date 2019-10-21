// 345. Reverse Vowels of a String

using System.Linq;

namespace LeetCodeDemo.Easy
{
    class Reverse_Vowels_of_a_String
    {
        public static string ReverseVowels(string s)
        {
            char tmp;
            char[] chs = s.ToCharArray();
            for(int i = 0, j = chs.Length - 1; i < j; i++, j--)
            {
                while (i < j && !IsVowel(chs[i])) i++;
                while (i < j && !IsVowel(chs[j])) j--;
                tmp = chs[j];
                chs[j] = chs[i];
                chs[i] = tmp;
            }
            return string.Join("", chs);
        }

        public static bool IsVowel(char ch)
        {
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
            return vowels.Contains(ch);
        }
    }
}
