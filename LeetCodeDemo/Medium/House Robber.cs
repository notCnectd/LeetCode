// 198.House Robber

using System;

namespace LeetCodeDemo.Medium {
    class House_Robber {
        public int Rob(int[] nums) {
            int newMoney = 0;
            int preMoney = 0;
            // dp[k] = max(dp[k - 1], dp[k - 2] + nums[k - 1])
            foreach (int num in nums) {
                int tmp = preMoney;
                preMoney = newMoney;
                newMoney = Math.Max(tmp + num, newMoney);
            }
            return newMoney;
        }
    }
}
