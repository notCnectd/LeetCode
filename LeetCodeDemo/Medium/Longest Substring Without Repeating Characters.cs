// 3. Longest Substring Without Repeating Characters

using System.Collections.Generic;

namespace LeetCodeDemo.Medium {
    class Longest_Substring_Without_Repeating_Characters {
        public static int LengthOfLongestSubstring(string s) {
            Queue<char> que = new Queue<char>();
            HashSet<char> hashTable = new HashSet<char>();
            int len = 0, cur = 0;
            foreach (char ch in  s) {
                if (hashTable.Contains(ch)) {
                    len = cur > len ? cur : len;
                    while (que.Peek() != ch) {
                        hashTable.Remove(que.Dequeue());
                    }
                    hashTable.Remove(que.Dequeue());
                    cur = que.Count;
                    hashTable.Add(ch);
                    que.Enqueue(ch);
                    
                } else {
                    que.Enqueue(ch);
                    hashTable.Add(ch);
                }
                cur++;
            }
            len = cur > len ? cur : len;
            return len;
        }
    }
}
