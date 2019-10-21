using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

// Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
// Symbol      Value
//   I           1
//   V           5
//   X           10
//   L           50
//   C           100
//   D           500
//   M           1000
// Example 1:
//    Input: "III"
//    Output: 3

// Example 2:
//    Input: "IV"
//    Output: 4

// Example 3:
//    Input: "IX"
//    Output: 9

// Example 4:
//    Input: "LVIII"
//    Output: 58
//    Explanation: L = 50, V= 5, III = 3.

// Example 5:
//    Input: "MCMXCIV"
//    Output: 1994
//    Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
namespace LeetCodeDemo.Easy
{
    class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            Hashtable keyValuePair = new Hashtable();
            keyValuePair = HashOfSpecial();
            Queue<char> queue = new Queue<char>(2);
            int num = 0;
            char temp;
            string special;
            for (int i = 0; i < s.Length; i++)
            {
                queue.Enqueue(s[i]);
                if (queue.Count == 2)
                {
                    temp = queue.Dequeue();
                    special = temp + queue.Peek().ToString();
                    if (keyValuePair.ContainsKey(special))
                    {
                        num += (int)keyValuePair[special];
                        queue.Dequeue();
                    }
                    else
                    {
                        num += RomanToInt(temp);
                    }               

                }
                if (i == s.Length - 1 && queue.Count == 1)
                {
                    num += RomanToInt(queue.Dequeue());
                }
            }

            return num;

        }

        // Create a hashtable to store special situations
        public static Hashtable HashOfSpecial()
        {
            Hashtable ht = new Hashtable();
            // keys are the roman numerals, values are the integer
            ht.Add("IV", 4);
            ht.Add("IX", 9);
            ht.Add("XL", 40);
            ht.Add("XC", 90);
            ht.Add("CD", 400);
            ht.Add("CM", 900);
            return ht;
        }

        // Transform one Roman symbol to a corresponding integer
        public static int RomanToInt(char r)
        {
            int num = 0;
            switch (r)
            {
                case 'I':
                    num = 1;
                    break;
                case 'V':
                    num = 5;
                    break;
                case 'X':
                    num = 10;
                    break;
                case 'L':
                    num = 50;
                    break;
                case 'C':
                    num = 100;
                    break;
                case 'D':
                    num = 500;
                    break;
                case 'M':
                    num = 1000;
                    break;
            }
            return num;
        }

    }
}
