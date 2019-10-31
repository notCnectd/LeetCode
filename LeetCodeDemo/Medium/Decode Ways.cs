// 91. Decode Ways

namespace LeetCodeDemo.Medium {
    class Decode_Ways {
        public int NumDecodings(string s) {
            if (s[0] == '0') return 0;
            int[] dp = new int[s.Length];
            dp[0] = 1;
            for (int i = 1; i < s.Length; i++) {
                int num = (s[i - 1] - '0') * 10 + s[i] - '0';
                if (s[i] == '0' && s[i - 1] == '0')
                    return 0;
                else if (s[i] == '0' && num > 26)
                    return 0;
                else if (s[i] == '0' && i > 1)
                    dp[i] = dp[i - 2];
                else if (s[i] == '0' || s[i - 1] == '0' || num > 26)
                    dp[i] = dp[i - 1];
                else if (num <= 26 && i > 1)
                    dp[i] = dp[i - 1] + dp[i - 2];
                else
                    dp[i] = dp[i - 1] + 1;
            }
            return dp[s.Length - 1];
        }
    }
}
