// 289. Game of Life

namespace LeetCodeDemo.Easy {
    class Game_of_Life {
        public void GameOfLife(int[][] board) {
            int row = board.Length;
            int col = board[0].Length;
            // 两边遍历，第一遍用特殊的数字标记需要改变的位置，第二遍正式改变数组
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    board[i][j] = isChenge(board, i, j, row, col);
                }
            }

            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    if (board[i][j] == 2)
                        board[i][j] = 1;
                    else if (board[i][j] == -1)
                        board[i][j] = 0;
                }
            }
        }

        public int isChenge(int[][] board, int row, int col, int m, int n) {
            int left = col - 1 > 0 ? col - 1 : 0;
            int right = col + 1 < n - 1 ? col + 1 : n - 1;
            int top = row - 1 > 0 ? row - 1 : 0;
            int bottom = row + 1 < m - 1 ? row + 1 : m - 1;
            int alive = 0;
            for (int i = top; i <= bottom; i++) {
                for (int j = left; j <= right; j++) {
                    // 注意有些1被换成了-1
                    if ((board[i][j] == 1 || board[i][j] == -1) && (i != row || j != col))
                        alive++;
                }
            }
            if (board[row][col] == 1 && (alive < 2 || alive > 3)) {
                return -1;
            } else if (board[row][col] == 0 && alive == 3) {
                return 2;
            } else
                return board[row][col];
        }
    }
}
