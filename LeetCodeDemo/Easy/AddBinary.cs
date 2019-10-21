// 67. Add Binary
using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCodeDemo.Easy
{
    class AddBinary
    {
        public static string Add_Binary(string a, string b)
        {
            int numOfZero = a.Length - b.Length;            
            if (numOfZero > 0)
            {
                for (int i = 0; i < numOfZero; i++)
                {
                    b = '0' + b;
                }
            }
            if (numOfZero < 0)
            {
                for (int i = 0; i < -numOfZero; i++)
                {
                    a = '0' + a;
                }
            }
            bool isCarry = false;
            string result = "";
            for (int i = a.Length - 1; i >= 0;)
            {
                int temp = Convert.ToInt32(a[i]) ^ Convert.ToInt32(b[i]);
                if (isCarry)
                {
                    if (a[i].Equals('0') && b[i].Equals('0')) isCarry = false;
                    temp = temp ^ 1;
                    result = temp + result;
                }
                else
                {
                    result = temp + result;
                    if (temp == 0 && a[i].Equals('1') && b[i].Equals('1')) isCarry = true;
                }
                i--;
                if (i < 0 && isCarry == true) result = 1 + result;
            }
            return result;
        }
    }
}
