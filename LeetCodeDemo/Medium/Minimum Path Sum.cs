// 64. Minimum Path Sum

using System;

namespace LeetCodeDemo.Medium {
    class Minimum_Path_Sum {
        public int MinPathSum(int[][] grid) {
            int row = grid.Length;
            int col = grid[0].Length;
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++) {
                    if (i == 0 && j != 0)
                        grid[i][j] += grid[i][j - 1];
                    else if (i != 0 && j == 0)
                        grid[i][j] += grid[i - 1][j];
                    else if (i != 0 && j != 0) {
                        grid[i][j] += Math.Min(grid[i - 1][j], grid[i][j - 1]);
                    }
                }
            return grid[row - 1][col - 1];
        }
    }
}
