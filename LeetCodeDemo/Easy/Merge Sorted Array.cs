// 88. Merge Sorted Array

namespace LeetCodeDemo.Easy {
    class Merge_Sorted_Array {
        public static void Merge(int[] nums1, int m, int[] nums2, int n) {
            int pos1 = m - 1;
            int pos2 = n - 1;
            int pos = m + n - 1;
            while (pos1 >= 0 && pos2 >= 0) {
                nums1[pos--] = nums1[pos1] > nums2[pos2] ? nums1[pos1--] : nums2[pos2--];
            }
            if (pos1 < 0) {
                while(pos > 0)
                    nums1[pos--] = nums2[pos2--];
            }
        }
    }
}
