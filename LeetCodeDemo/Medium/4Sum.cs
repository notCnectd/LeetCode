// 18. 4Sum

using System;
using System.Collections.Generic;


namespace LeetCodeDemo.Medium {
    class _4Sum {
        public IList<IList<int>> FourSum(int[] nums, int target) {
            Array.Sort(nums);
            IList<IList<int>> res = new List<IList<int>>();
            int len = nums.Length;
            for (int fir = 0; fir < len - 3;) {
                for (int sec = fir + 1; sec < len - 2;) {
                    int front = sec + 1;
                    int end = len - 1;
                    while (front < end) {
                        int sum = nums[fir] + nums[sec] + nums[front] + nums[end];
                        if (sum == target) {
                            res.Add(new List<int>() {
                            nums[fir],
                            nums[sec],
                            nums[front],
                            nums[end]
                        });
                            while (front < end && nums[front] == nums[++front]) ;
                        } else if (sum < target) {
                            while (front < end && nums[front] == nums[++front]) ;
                        } else {
                            while (front < end && nums[end] == nums[--end]) ;
                        }
                    }
                    while (sec < len - 2 && nums[sec] == nums[++sec]) ;
                }
                while (fir < len - 3 && nums[fir] == nums[++fir]) ;
            }
            return res;
        }
    }
}
