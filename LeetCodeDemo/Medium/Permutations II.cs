// 47. Permutations II

using System.Collections.Generic;

namespace LeetCodeDemo.Medium {
    class Permutations_II {
        public IList<IList<int>> PermuteUnique(int[] nums) {
            IList<IList<int>> res = new List<IList<int>>();
            PermutationUnique(res, nums, nums.Length, 0);
            return res;
        }

        public void PermutationUnique(IList<IList<int>> res, int[] nums, int len, int index) {
            if (len == index) {
                res.Add(new List<int>(nums));
            } else {
                for (int i = index; i < len; i++) {
                    if (nums[i] != nums[index]) {
                        Swap(nums, i, index);
                        PermutationUnique(res, nums, len, index + 1);
                        Swap(nums, i, index);
                    }
                }
            }
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
