// 5. Longest Palindromic Substring

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Medium {
    class Longest_Palindromic_Substring {
        // 动态规划
        // bool dp[l][r] 代表从l到r的字串是否是回文串
        // dp[l][r] = (s[l]==s[r] && (r-l==1 || dp[l+1][r-1]))
        public string LongestPalindrome(string s) {
            bool[][] dp = new bool[s.Length][];
            for (int i = 0; i < dp.Length; i++) {
                dp[i] = new bool[s.Length];
                dp[i][i] = true;
            }
            int start = 0, end = 0;
            for (int r = 1; r < s.Length; r++)
                for (int l = 0; l < r; l++) {
                    if (s[r] == s[l] && (r - l == 1 || dp[l + 1][r - 1])) {
                        dp[l][r] = true;
                        if (r - l >= end - start) {
                            start = l;
                            end = r;
                        }
                    } else {
                        dp[l][r] = false;
                    }
                }
            return s.Substring(start, end - start + 1);
        }
    }
}
