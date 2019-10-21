// 75. Sort Colors

namespace LeetCodeDemo.Medium {
    class Sort_Colors {
        public void SortColors(int[] nums) {
            // 3路排序
            int len = nums.Length;
            int front = 0;
            int end = len - 1;
            int notSure = front - 1;
            while (front <= end) {
                if (nums[front] == 2) {
                    swap(nums, front, end--);
                } else if (nums[front] == 0) {
                    swap(nums, ++notSure, front++);
                } else
                    front++;
            }
        }

        public void swap(int[] nums, int i, int j) {
            int tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }
    }
}
