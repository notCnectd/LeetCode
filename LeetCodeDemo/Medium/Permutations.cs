// 46. Permutations


using System;
using System.Collections.Generic;

namespace LeetCodeDemo.Medium {
    class Permutations {
        // 递归 

        //public IList<IList<int>> Permute(int[] nums) {
        //    IList<IList<int>> res = new List<IList<int>>();
        //    Permutation(res, nums, nums.Length, 0);
        //    return res;
        //}

        //public void Permutation(IList<IList<int>> res, int[] nums, int len, int index) {
        //    if (index == len) {
        //        // 引用传递， 必须拷贝一份
        //        res.Add(new List<int>(nums));
        //    } else {
        //        for (int i = index; i < len; i++) {
        //            Swap(nums, i, index);
        //            Permutation(res, nums, len, index + 1);
        //            Swap(nums, i, index);
        //        }
        //    }
        //}

        public int FindLeastBigger(int[] nums, int changePoint, int end) {
            int i = changePoint, j = end;
            while (nums[j] < nums[i]) {
                j--;
            }
            return j;
        }

        // 字典序
        public IList<IList<int>> Permute(int[] nums) {
            IList<IList<int>> res = new List<IList<int>>();
            // 先排序
            Array.Sort(nums);
            res.Add(new List<int>(nums));
            int len = nums.Length;
            int end = len - 1;
            int i = end;
            // 从后往前遍历
            while (i > 0) {
                int j = i;
                i--;
                // i 代表交换点，第一个比尾元素小的元素
                if (nums[i] < nums[j]) {
                    // 找到比交换点大的最小元素
                    int bigger = FindLeastBigger(nums, i, end);
                    //  交换两者
                    Swap(nums, i, bigger);
                    // 逆序交换点后的成员
                    Reverse(nums, i + 1, end);
                    res.Add(new List<int>(nums));
                    // 初始化起始点为尾部
                    i = end;
                }
                if (i == 0) break;
            }
            return res;
        }

        public void Swap(int[] nums, int i, int j) {
            int tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }

        public void Reverse(int[] nums, int i, int j) {
            while (i < j) {
                int tmp = nums[i];
                nums[i] = nums[j];
                nums[j] = tmp;
                i++;
                j--;
            }
        }
    }
}
