// 279. Perfect Squares


using System;

namespace LeetCodeDemo.Medium {
    class Perfect_Squares {
        public int NumSquares(int n) {
            int[] dp = new int[n + 1];
            dp[0] = 0;
            for (int i = 1; i <= n; i++) {
                // 即i个1为初始结果
                dp[i] = i;
                // j * j就是最大的完全平方数
                for (int j = 1; i - j * j >= 0; j++) {
                    // 状态转移公式 
                    dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
                }
            }
            return dp[n];
        }
    }
}
