// 62. Unique Paths

namespace LeetCodeDemo.Medium {
    class Unique_Paths {
        public int UniquePaths(int m, int n) {
            // 动态规划
            int[][] board = new int[n][];
            for (int i = 0; i < n; i++) {
                board[i] = new int[m];
            }
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    if (i == 0 || j == 0)
                        // 状态
                        board[i][j] = 1;
                    else {
                        // 状态转移公式
                        board[i][j] = board[i - 1][j] + board[i][j - 1];
                    }
                }
            }
            return board[n - 1][m - 1];
        }
    }
}
