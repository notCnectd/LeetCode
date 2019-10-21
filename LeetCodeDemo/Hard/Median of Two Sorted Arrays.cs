// 4. Median of Two Sorted Arrays

namespace LeetCodeDemo.Hard {
    class Median_of_Two_Sorted_Arrays {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2) {
            int len1 = nums1.Length, len2 = nums2.Length;
            // 数组2的长度必须大于等于数组1的长度
            if (len1 > len2) {
                int[] tmp = nums1;
                nums1 = nums2;
                nums2 = tmp;
                len1 = nums1.Length;
                len2 = nums2.Length;
            }
            int iMin = 0, iMax = len1;
            int halfLen = (len1 + len2 + 1) / 2;
            // 将两数组转化成长度相同的两部分
            while (iMin <= iMax) {
                int i = (iMin + iMax) / 2;
                // j的位置，与i的关系： 始终保持：i + j = len1 - i + len2 - j
                int j = halfLen - i;
                if (i < iMax && nums1[i] < nums2[j - 1]) {
                    iMin = i + 1;
                }
                else if (i > iMin && nums1[i - 1] > nums2[j]) {
                    iMax = i - 1;
                }
                else {
                    int leftMax = 0;
                    if (i == 0) leftMax = nums2[j - 1];
                    else if (j == 0) leftMax = nums1[i - 1];
                    else leftMax = nums1[i - 1] > nums2[j - 1] ? nums1[i - 1] : nums2[j - 1];
                    if ((len1 + len2) % 2 == 1) return leftMax; 

                    int rightMin = 0;
                    if (i == len1) rightMin = nums2[j];
                    else if (j == len2) rightMin = nums1[i];
                    else rightMin = nums1[i] < nums2[j] ? nums1[i] : nums2[j];
                    return (leftMax + rightMin) / 2.0;
                }
            }
            return 0;
        }
    }
}
