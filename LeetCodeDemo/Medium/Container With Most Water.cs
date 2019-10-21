// 11. Container With Most Water

using System;

namespace LeetCodeDemo.Medium {
    class Container_With_Most_Water {
        public int MaxArea(int[] height) {
            // 设置双指针一头一尾，计算两指针之间的面积，然后长度较短的指针向较长的指针移动一步
            // 因为容器的面积受限于较短的一边，两指针距离越远面积越大，所以指针初始位置一头一尾
            int len = height.Length;
            int front = 0;
            int end = len - 1;
            int maxArea = 0;
            while (front <= end) {
                int shorter = Math.Min(height[front], height[end]);
                maxArea = Math.Max(shorter * (end - front), maxArea);
                if (shorter == height[front])
                    front++;
                else
                    end--;
            }
            return maxArea;
        }
    }
}
