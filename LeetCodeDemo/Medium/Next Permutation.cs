// 31. Next Permutation

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Medium {
    class Next_Permutation {
        public void NextPermutation(int[] nums) {
            int end = nums.Length - 1;
            int i = end;
            while (i > 0) {
                int j = i;
                i--;
                if (nums[i] < nums[j]) {
                    int k = end;
                    while (nums[k] <= nums[i])
                        k--;
                    if (nums[i] != nums[k]) {
                        Swap(nums, i, k);
                        Reverse(nums, i + 1, end);
                        return;
                    }
                    i = end;
                }
                if (i == 0)
                    Reverse(nums, 0, end);
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
