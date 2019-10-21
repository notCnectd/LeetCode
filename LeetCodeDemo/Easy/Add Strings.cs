// 415. Add Strings

namespace LeetCodeDemo.Easy
{
    class Add_Strings
    {
        public static string AddStrings(string num1, string num2)
        {
            int size1 = num1.Length, size2 = num2.Length;
            if (size1 > size2)
            {
                for (int i = 0; i < size1 - size2; i++) num2 = '0' + num2;
                size2 = size1;
            }
            else
            {
                for (int i = 0; i < size2 - size1; i++) num1 = '0' + num1;
                size1 = size2;
            }
            int carry = 0, temp = 0, val = 0;
            string res = "";
            for (int i = size1 - 1; i >= 0; i--)
            {
                temp = num1[i] - '0' + num2[i] - '0' + carry;
                carry = temp / 10;
                val = temp % 10;
                res = val + res;
            }
            if (carry != 0) res = carry + res;
            return res;
        }
    }
}

