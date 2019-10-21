// 15. 3Sum

using System;
using System.Collections.Generic;

namespace LeetCodeDemo.Medium {
    class _3Sum {
        public IList<IList<int>> ThreeSum(int[] nums) {
            // 排序数组
            Array.Sort(nums);
            IList<IList<int>> res = new List<IList<int>>();
            int len = nums.Length;
            int front = 0;
            for (; front < len - 2;) {
                // 使用3个指针，一头一尾一中
                // 遍历最前的指针，每次遍历开始时尾指针永远在数组的尾部，中指针永远在头指针+1的位置
                int mid = front + 1;
                int end = len - 1;
                // 中、尾指针相交时结束循环
                while (mid < end) {
                    // 头指针位置大于0直接结束
                    if (nums[front] > 0)
                        return res;
                    // 尾指针位置小于0直接结束
                    if (nums[end] < 0)
                        return res;
                    // 头指针位置等于0则判断前面的两个指针位置是否都为0
                    if (nums[front] == 0) {
                        if (nums[mid] == 0 && nums[end] == 0) {
                            res.Add(new List<int>() { 0, 0, 0 });
                            return res;
                        }
                    }
                    int sum = nums[front] + nums[mid] + nums[end];
                    if (sum == 0) {
                        res.Add(new List<int>() { nums[front], nums[mid], nums[end] });
                        // 每次挪动指针都要跳过重复元素
                        while (mid < end && nums[mid] == nums[++mid]) ;
                    } else if (sum < 0) {
                        // 每次挪动指针都要跳过重复元素
                        while (mid < end && nums[mid] == nums[++mid]) ;
                    } else {
                        // 每次挪动指针都要跳过重复元素
                        while (mid < end && nums[end] == nums[--end]) ;
                    }
                }
                // 每次挪动指针都要跳过重复元素
                while (front < len - 2 && nums[front] == nums[++front]) ;
            }
            return res;
        }
    }
}
