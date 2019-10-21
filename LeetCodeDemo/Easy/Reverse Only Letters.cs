// 917. Reverse Only Letters

namespace LeetCodeDemo.Easy
{
    class Reverse_Only_Letters
    {
        public static string ReverseOnlyLetters(string S)
        {           
            int size = S.Length;
            char temp;
            char[] res = S.ToCharArray();
            for (int i = 0, j = size - 1; i < j ; i++, j--)
            {
                while (i < j && !(S[i] >= 'a' && S[i] <= 'z' || S[i] >= 'A' && S[i] <= 'Z'))
                    i++;
                while (i < j && !(S[j] >= 'a' && S[j] <= 'z' || S[j] >= 'A' && S[j] <= 'Z'))
                    j--;
                temp = res[j];
                res[j] = res[i];
                res[i] = temp;
            }
            string ans = "";
            for (int i = 0; i < size; i++) ans += res[i];
            return ans;
        }
    }
}
