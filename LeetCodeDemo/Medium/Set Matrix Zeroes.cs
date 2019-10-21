// 73. Set Matrix Zeroes

namespace LeetCodeDemo.Medium {
    class Set_Matrix_Zeroes {
        public static void SetZeroes(int[][] matrix) {
            int m = matrix.Length;
            if (m == 0) return;
            int n = matrix[0].Length;
            bool rowFlag = false, colFlag = false;
            if (matrix[0][0] == 0) {
                rowFlag = true;
                colFlag = true;
            }
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (matrix[i][j] == 0) {
                        if (i == 0) rowFlag = true;
                        if (j == 0) colFlag = true;
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }
            for (int i = 1; i < m; i++) {
                if (matrix[i][0] == 0) {
                    for (int j = 1; j < n; j++)
                        matrix[i][j] = 0;
                }
            }

            for (int i = 1; i < n; i++) {
                if (matrix[0][i] == 0) {
                    for (int j = 1; j < m; j++)
                        matrix[j][i] = 0;
                }
            }

            if (rowFlag) {
                for (int i = 1; i < n; i++)
                    matrix[0][i] = 0;
            }
            if (colFlag) {
                for (int i = 1; i < m; i++)
                    matrix[i][0] = 0;
            }
        }
    }
}
