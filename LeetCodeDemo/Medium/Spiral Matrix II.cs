// 59. Spiral Matrix II

namespace LeetCodeDemo.Medium {
    class Spiral_Matrix_II {
        public static int[][] GenerateMatrix(int n) {
            int[][] res = new int[n][];
            int i;
            for (i = 0; i < n; i++) {
                res[i] = new int[n];
            }
            if (n == 0) return res;
            int top = 0;
            int bottom = n - 1;
            int left = 0;
            int right = n - 1;
            int start = 1;
            int end = n * n;
            while (start <= end) {
                for (i = left; i <= right; i++)
                    res[top][i] = start++;
                if (++top > bottom) break;
                for (i = top; i <= bottom; i++)
                    res[i][right] = start++;
                right--;
                for (i = right; i >= left; i--)
                    res[bottom][i] = start++;
                bottom--;
                for (i = bottom; i >= top; i--)
                    res[i][left] = start++;
                left++;
            }
            return res;
        }
    }
}
