// 54. Spiral Matrix

using System.Collections.Generic;

namespace LeetCodeDemo.Medium {
    class Spiral_Matrix {
        public IList<int> SpiralOrder(int[][] matrix) {
            IList<int> res = new List<int>();
            int up = 0;
            int down = matrix.Length - 1;
            if (down < 0) return res;
            int left = 0;
            int right = matrix[0].Length - 1;
            int i = 0;
            while (true) {
                for (i = left; i <= right; i++)
                    res.Add(matrix[up][i]);
                up++;
                if (up > down) break;
                for (i = up; i <= down; i++)
                    res.Add(matrix[i][right]);
                right--;
                if (left > right) break;
                for (i = right; i >= left; i--)
                    res.Add(matrix[down][i]);
                down--;
                if (up > down) break;
                for (i = down; i >= up; i--)
                    res.Add(matrix[i][left]);
                left++;
                if (left > right) break;
            }
            return res;
        }
    }
}
