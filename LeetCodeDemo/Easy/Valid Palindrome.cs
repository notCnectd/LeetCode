// 125. Valid Palindrome

namespace LeetCodeDemo.Easy
{
    class Valid_Palindrome
    {
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                while (!(s[i] >= 'a' && s[i] <= 'z' || s[i] >= '0' && s[i] <= '9') && i < j) i++;
                while (!(s[j] >= 'a' && s[j] <= 'z' || s[j] >= '0' && s[j] <= '9') && j > i) j--;
                if (s[i] != s[j]) return false;
            }
            return true;
        }
    }
}
