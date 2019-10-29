// 42. Trapping Rain Water

using System;
using System.Collections.Generic;

namespace LeetCodeDemo.Hard {
    class Trapping_Rain_Water {
        // 使用栈
        //public int Trap(int[] height) {
        //    int rain = 0;
        //    // 递减栈记录索引
        //    Stack<int> stack = new Stack<int>();
        //    stack.Push(0);
        //    int i = 1;
        //    while (stack.Count > 0 && i < height.Length) {
        //        if (height[i] < height[stack.Peek()]) {
        //            stack.Push(i++);
        //        } else {
        //            while (stack.Count > 0 && height[i] >= height[stack.Peek()]) {
        //                int cur = height[stack.Pop()];
        //                int before = (stack.Count == 0) ? 0 : height[stack.Peek()];
        //                // 要注意距离
        //                if (before > cur)
        //                    rain += (Math.Min(before, height[i]) - cur) * (i - stack.Peek() - 1);
        //            }
        //            stack.Push(i++);
        //        }
        //    }
        //    return rain;
        //}

        // 使用动态规划
        //public int Trap(int[] height) {
        //    int rain = 0;
        //    int[] maxLeft = new int[height.Length];
        //    int[] maxRight = new int[height.Length];
        //    for (int i = 1; i < height.Length; i++) {
        //        // dp转移公式
        //        maxLeft[i] = maxLeft[i - 1] > height[i - 1] ? maxLeft[i - 1] : height[i - 1];
        //    }
        //    for (int i = height.Length - 2; i >= 0; i--) {
        //        maxRight[i] = maxRight[i + 1] > height[i + 1] ? maxRight[i + 1] : height[i + 1];
        //    }
        //    for (int i = 0; i < height.Length; i++) {
        //        int shorter = Math.Min(maxLeft[i], maxRight[i]);
        //        rain += shorter > height[i] ? (shorter - height[i]) : 0;
        //    }
        //    return rain;
        //}

        // 动态规划+双指针
        public int Trap(int[] height) {
            int rain = 0;
            int maxLeft = 0;
            int maxRight = 0;
            int left = 1;
            int right = height.Length - 2;
            for (int i = 1; i < height.Length - 1; i++) {
                if (height[left - 1] < height[right + 1]) {
                    // dp转移公式
                    maxLeft = maxLeft > height[left - 1] ? maxLeft : height[left - 1];
                    if (maxLeft > height[left])
                        rain += maxLeft - height[left];
                    left++;
                } else {
                    // dp转移公式
                    maxRight = maxRight > height[right + 1] ? maxRight : height[right + 1];
                    if (maxRight > height[right])
                        rain += maxRight - height[right];
                    right--;
                }
            }
            return rain;
        }
    }
}
