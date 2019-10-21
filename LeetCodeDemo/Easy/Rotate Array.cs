// 189. Rotate Array


namespace LeetCodeDemo.Easy {
    class Rotate_Array {
        public void Rotate(int[] nums, int k) {
            int len = nums.Length;
            if (len == 0) return;
            int count = 0;
            k = k % len;
            for (int starr = 0; count < len; starr++) {
                int preV = nums[starr];
                int cur = starr;
                // 按k个长度对每一个数循环交换，直到最新的索引等于最初的索引
                do {
                    int next = (cur + k) % len;
                    int temp = nums[next];
                    nums[next] = preV;
                    cur = next;
                    preV = temp;
                    count++;
                } while (starr != cur);
            }
        }

        // O(kn) 超时
        // public void Rotate(int[] nums, int k) {
        //     int len = nums.Length;
        //     for (int i = 0; i < k; i++) {
        //         int cur = nums[len - 1];
        //         for (int j = 0; j < len; j++) {
        //             int temp = nums[j];
        //             nums[j] = cur;
        //             cur = temp;
        //         }
        //     }
        // }

        //public void Rotate(int[] nums, int k) {
        //    int len = nums.Length;
        //    int mid = len - k % len;
        //    reverse(nums, 0, mid - 1);
        //    reverse(nums, mid, len - 1);
        //    reverse(nums, 0, len - 1);
        //}

        //public void reverse(int[] nums, int starr, int end) {
        //    for (int i = starr, j = end; i < j; i++, j--) {
        //        int tmp = nums[i];
        //        nums[i] = nums[j];
        //        nums[j] = tmp;
        //    }
        //}
    }
}
