// 804. Unique Morse Code Words
using System.Collections.Generic;

namespace LeetCodeDemo.Easy
{
    class Unique_Morse_Code_Words
    {
        public static int UniqueMorseRepresentations(string[] words)
        {
            HashSet<string> hs = new HashSet<string>(); 
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
                "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
                "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            foreach (string word in words)
            {
                string str = "";
                foreach (char letter in word)
                    str += morse[letter - 'a'];
                hs.Add(str);
            }
            return hs.Count;
        }
    }
}
