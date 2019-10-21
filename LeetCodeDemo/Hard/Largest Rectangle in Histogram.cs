// 84. Largest Rectangle in Histogram

using System.Collections.Generic;

namespace LeetCodeDemo.Hard {
    class Largest_Rectangle_in_Histogram {
        // 暴力法 超时
        public static int LargestRectangleArea1(int[] heights) {
            int max = 0;
            for (int i = 0; i < heights.Length; i++) {
                int j = i - 1, k = i + 1;
                while (j >= 0 && heights[i] <= heights[j]) j--;
                while (k < heights.Length && heights[i] <= heights[k]) k++;
                int area = (k - j - 1) * heights[i];
                max = max > area ? max : area;
            }
            return max;
        }

        // 单调栈 O(n) O(n)
        public static int LargestRectangleArea2(int[] heights) {
            if (heights.Length == 0) return 0;
            // 栈用于存放heights的索引
            Stack<int> stack = new Stack<int>();
            // 存放索引-1 为最左边元素索引
            stack.Push(-1);
            stack.Push(0);
            int max = heights[0], val = 0;
            for (int i = 1; i < heights.Length; i++) {
                while (stack.Count > 1 && heights[stack.Peek()] >= heights[i]) {
                    val = heights[stack.Pop()] * (i - stack.Peek() - 1);
                    max = val > max ? val : max;
                }
                stack.Push(i);
            }
            val = 0;
            while (stack.Count > 1) {
                val = heights[stack.Pop()] * (heights.Length - stack.Peek() - 1);
                max = val > max ? val : max;
            }
            return max;
        }


        //public static int LargestRectangleArea3(int[] heights) {

        //}
    }
}
