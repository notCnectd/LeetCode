// 152. Maximum Product Subarray

using System;

namespace LeetCodeDemo.Medium {
    class Maximum_Product_Subarray {
        public int MaxProduct(int[] nums) {
            if (nums.Length == 0) return 0;
            int product = nums[0];
            int mulMax = nums[0];
            int mulMin = nums[0];
            for (int i = 1; i < nums.Length; i++) {
                // 同时记录当前的最大和最小值
                int curMax = Math.Max(Math.Max(nums[i] * mulMax, nums[i] * mulMin), nums[i]);
                int curMin = Math.Min(Math.Min(nums[i] * mulMax, nums[i] * mulMin), nums[i]);
                product = product > curMax ? product : curMax;
                mulMax = curMax;
                mulMin = curMin;
            }
            return product;
        }
    }
}
