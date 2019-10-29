// 120. Triangle

using System;
using System.Collections.Generic;

namespace LeetCodeDemo.Medium {
    class Triangle {
        public int MinimumTotal(IList<IList<int>> triangle) {
            int height = triangle.Count;
            for (int i = 0; i < height; i++)
                for (int j = 0; j < triangle[i].Count; j++) {
                    if (i == 0) continue;
                    else if (j == 0) {
                        triangle[i][j] += triangle[i - 1][j];
                    } else if (j < i)
                        triangle[i][j] += Math.Min(triangle[i - 1][j], triangle[i - 1][j - 1]);
                    else
                        triangle[i][j] += triangle[i - 1][j - 1];
                }
            int min = int.MaxValue;
            for (int i = 0; i < triangle[height - 1].Count; i++) {
                min = min < triangle[height - 1][i] ? min : triangle[height - 1][i];
            }
            return min;
        }
    }
}
