// 139. Word Break


namespace LeetCodeDemo.Medium {
    class Word_Break {
        // 暴力法
        // public bool WordBreak(string s, IList<string> wordDict) {
        // 转成HashSet来调用Contains()       
        //     return Break(s, new HashSet<string>(wordDict), 0);
        // }

        // public bool Break(string s, HashSet<string> wordDict, int start) {
        //     if (start == s.Length) 
        //         return true;
        //     else {
        //         for (int end = start + 1; end <= s.Length; end++) {
        //             if (wordDict.Contains(s.Substring(start, end - start)) && Break(s, wordDict, end))
        //                 return true;
        //         }
        //     }
        //     return false;
        // }

        // 动态规划
        //public bool WordBreak(string s, IList<string> wordDict) {
        //    HashSet<string> wordSet = new HashSet<string>(wordDict);
        //    // dp[]的每一个索引的前缀串和之后没有关系
        //    bool[] dp = new bool[s.Length + 1];
        //    dp[0] = true;
        //    for (int i = 1; i <= s.Length; i++)
        //        for (int j = 0; j < i; j++) {
        //            // dp[k] = dp[j] == true && wordSet.Contains(j, k - j) (j < k)
        //            if (dp[j] && wordSet.Contains(s.Substring(j, i - j))) {
        //                dp[i] = true;
        //                break;
        //            }
        //        }
        //    return dp[s.Length];
        //}


        
       
        
    }
}
