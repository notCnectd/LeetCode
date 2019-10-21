﻿// Given two strings s and t which consist of only lowercase letters.
// String t is generated by random shuffling string s and then add one more letter at a random position.
// Find the letter that was added in t.
// Example:
    // Input:
        // s = "abcd"
        // t = "abcde"
    // Output:
        // e
    // Explanation:
        // 'e' is the letter that was added.

using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCodeDemo.Easy
{
    class FindTheDifference
    {
        //public static char Find_The_Difference(string s, string t)
        //{
        //    char[] temp = new char[t.Length];
        //    Hashtable keyValuePair = new Hashtable();
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        keyValuePair.Add(i, s[i]);
        //    }

        //    for (int i = 0; i < t.Length; i++)
        //    {
        //        if (keyValuePair.ContainsValue(t[i]))
        //        {              
        //            keyValuePair.Remove(keyValuePair.ContainsValue(t[i]).GetHashCode());
        //            temp[i] = ' ';
        //        }
        //        else
        //        {
        //            temp[i] = t[i];
        //        }
        //    }

        //    for (int i = 0; i < temp.Length; i++)
        //    {
        //        if (temp[i] != ' ')
        //        {
        //            return temp[i];
        //        }
        //    }
        //    return ' ';
        //}

        public static char Find_The_Difference(string s, string t)
        {
            // It also can be solved with bit operation.
            List<char> sCopy = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                sCopy.Add(s[i]);
            }
            foreach (char ch in t)
            {
                if (!sCopy.Contains(ch))
                {
                    return ch;
                }
                sCopy.Remove(ch);
            }

            return ' ';
        }

        public static char newSolution(string s, string t)
        {
            int temp1 = 0, temp2 = 0;
            foreach (char ch in s)
            {
                temp1 += ch;
            }

            foreach (char ch in t)
            {
                temp2 += ch;
            }

            return Convert.ToChar(temp2 - temp1);
        }
    }
}
