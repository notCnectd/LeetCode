// 48. Rotate Image

namespace LeetCodeDemo.Medium {
    class Rotate_Image {
        public void Rotate(int[][] matrix) {
            int x = 0;
            int y = matrix.Length - 1;
            // 从外到里一层一层的循环，x,y控制整体的层数
            while (x <= y) {
                int i = x;
                int j = y;
                // 注意没有相等！
                while (i < y) {
                    int tmp = matrix[x][i];
                    matrix[x][i] = matrix[j][x];
                    matrix[j][x] = matrix[y][j];
                    matrix[y][j] = matrix[i][y];
                    matrix[i][y] = tmp;
                    i++;
                    j--;
                }
                x++;
                y--;
            }
        }
    }
}
