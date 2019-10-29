// 43. Multiply Strings


namespace LeetCodeDemo.Medium {
    class Multiply_Strings {
        //public string Multiply(string num1, string num2) {
        //    if (num1 == "0" || num2 == "0") return "0";
        //    string res = "";
        //    int tens = 0;
        //    for (int i = num1.Length - 1; i >= 0; i--) {
        //        string tmp = MultiplyToStr(num1[i], num2);
        //        for (int j = 0; j < tens; j++)
        //            tmp += "0";
        //        tens++;
        //        res = StrPlusStr(res, tmp);
        //    }
        //    return res;
        //}

        //public string StrPlusStr(string num1, string num2) {
        //    string str = "";
        //    int len1 = num1.Length, len2 = num2.Length;
        //    if (len1 > len2) {
        //        for (int i = 0; i < len1 - len2; i++)
        //            num2 = "0" + num2;
        //    } else {
        //        for (int i = 0; i < len2 - len1; i++)
        //            num1 = "0" + num1;
        //    }
        //    int carry = 0;
        //    for (int i = num1.Length - 1; i >= 0; i--) {
        //        int tmp = num1[i] - '0' + num2[i] - '0' + carry;
        //        carry = tmp / 10;
        //        str = tmp % 10 + str;
        //    }
        //    if (carry != 0)
        //        str = carry + str;
        //    return str;
        //}

        //public string MultiplyToStr(char num, string numStr) {
        //    string res = "";
        //    int carry = 0;
        //    for (int i = numStr.Length - 1; i >= 0; i--) {
        //        int tmp = (numStr[i] - '0') * (num - '0') + carry;
        //        res = (tmp % 10) + res;
        //        carry = tmp / 10;
        //    }
        //    if (carry != 0)
        //        res = carry + res;
        //    return res;
        //}


        public static string Multiply(string num1, string num2) {
            int len1 = num1.Length, len2 = num2.Length;
            int[] product = new int[len1 + len2];
            for (int i = len1 - 1; i >= 0; i--)
                for (int j = len2 - 1; j >= 0; j--) {
                    product[i + j + 1] += (num2[j] - '0') * (num1[i] - '0');
                    product[i + j] += product[i + j + 1] / 10;
                    product[i + j + 1] %= 10;
                }
            string str = "";
            for (int i = product[0] == 0 ? 1 : 0; i < product.Length; i++) {
                str += product[i];
            }
            return str;
        }

        // public long CharMulStr(char num, string numStr) {
        //     long res = 0;
        //     int digits = 0;
        //     long carry = 0;
        //     for (int i = numStr.Length - 1; i >= 0; i--) {
        //         long tmp = ((numStr[i] - '0') * (num - '0')) + carry;
        //         carry = tmp / 10;
        //         res += (tmp % 10) * (long)Math.Pow(10, digits++);
        //     }
        //     res += carry * (long)Math.Pow(10, digits);
        //     return res;
        // }
    }
}
