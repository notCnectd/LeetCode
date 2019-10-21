// 520. Detect Capital
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Easy
{
    class DetectCapital
    {
        public static bool DetectCapitalUse(string word)
        {
            if (word.Length <= 1) return true; 
            if('a' <= word[0] && word[0] <= 'z')
            {
                for (int i = 1; i < word.Length; i++)
                {
                    if ('a' > word[i] || word[i] > 'z') return false;
                }
                return true;
            }
            else
            {
                if('a' <= word[1] && word[1] <= 'z')
                {
                    for (int i = 2; i < word.Length; i++)
                    {
                        if ('a' > word[i] || word[i] > 'z') return false;
                    }
                    return true;
                }
                else
                {
                    for (int i = 2; i < word.Length; i++)
                    {
                        if ('a' <= word[i] && word[i] <= 'z') return false;
                    }
                    return true;
                }
                    
            }
        }
    }
}
