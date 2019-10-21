// 26. Remove Duplicates from Sorted Array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Easy {
    class Remove_Duplicates_from_Sorted_Array {
        public int RemoveDuplicates(int[] nums) {
            int i = 0;
            int j = 1;
            int len = 1;
            while (j < nums.Length) {
                while (j < nums.Length && nums[i] == nums[j]) {
                    j++;
                }
                i++;
                len++;
                nums[i] = nums[j];
            }
            return len;
        }
    }
}
