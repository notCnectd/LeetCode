// 33. Search in Rotated Sorted Array

namespace LeetCodeDemo.Medium {
    class Search_in_Rotated_Sorted_Array {
        public int Search(int[] nums, int target) {
            int len = nums.Length;
            return Search(nums, target, 0, len - 1);
        }

        public int Search(int[] nums, int target, int left, int right) {
            int mid = (right + left) / 2;
            int index;
            if (nums[mid] == target)
                return mid;
            else {
                if (left > right)
                    return -1;
                else {
                    // 两种情况
                    if (nums[mid] > target && (nums[left] <= target || nums[left] > nums[mid]))
                        index = Search(nums, target, left, mid - 1);
                    else if (nums[mid] > target && nums[left] > target)
                        index = Search(nums, target, mid + 1, right);
                    else if (nums[mid] < target && (nums[right] >= target || nums[right] < nums[mid]))
                        index = Search(nums, target, mid + 1, right);
                    else
                        index = Search(nums, target, left, mid - 1);
                }
            }
            return index;
        }
    }
    
}
