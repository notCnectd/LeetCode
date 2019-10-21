// 80. Remove Duplicates from Sorted Array II

namespace LeetCodeDemo.Medium {
    class Remove_Duplicates_from_Sorted_Array_II {
        public int RemoveDuplicates(int[] nums) {
            int len = nums.Length;
            if (len <= 2) return len;
            // cur代表当前！！！有效！！！数组的最后一位
            int cur = 1;
            for (int i = 2; i < nums.Length; i++) {
                if (nums[cur - 1] != nums[i]) {
                    cur++;
                    nums[cur] = nums[i];
                }
            }
            return cur + 1;

        }
    }
}
