// 34. Find First and Last Position of Element in Sorted Array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Medium {
    class Find_First_and_Last_Position_of_Element_in_Sorted_Array {
        public int[] SearchRange(int[] nums, int target) {
            int[] res = { -1, -1 };
            res[0] = Search(nums, target, true);
            res[1] = Search(nums, target, false);
            return res;
        }
        // 分左右进行二分查找
        public int Search(int[] nums, int target, bool flag) {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right) {
                int mid = (left + right) >> 1;
                if (nums[mid] == target) {
                    // 关键 ！
                    int index = flag ? mid - 1 : mid + 1;
                    if (index < 0 || index == nums.Length || nums[index] != nums[mid])
                        return mid;
                    if (flag)
                        right = index;
                    else
                        left = index;
                } else if (nums[mid] < target) {
                    left = mid + 1;
                } else {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}
