// 213. House Robber II

using System;

namespace LeetCodeDemo.Medium {
    class House_Robber_II {
        public int Rob(int[] nums) {
            int len = nums.Length;
            if (len == 1) return nums[0];
            int money1 = 0;
            int money2 = 0;
            int preMoney = 0;
            // dp[k] = max(dp[k-1], dp[k-2] + nums[k-1])
            for (int i = 0; i < len - 1; i++) {
                int tmp = preMoney;
                preMoney = money1;
                money1 = Math.Max(money1, nums[i] + tmp);
            }
            preMoney = 0;
            for (int i = 1; i < len; i++) {
                int tmp = preMoney;
                preMoney = money2;
                money2 = Math.Max(money2, nums[i] + tmp);
            }
            return money2 > money1 ? money2 : money1;
        }
    }
}
