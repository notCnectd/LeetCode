// 1071. Greatest Common Divisor of Strings

namespace LeetCodeDemo.Easy
{
    class Greatest_Common_Divisor_of_Strings
    {
        public static string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1) return "";
            int len = Gcd(str1.Length, str2.Length);
            return str1.Substring(0, len);
        }

        public static int Gcd(int x, int y)
        {
            if (y == 0) return x;
            return Gcd(y, x % y);
        }
    }
}
