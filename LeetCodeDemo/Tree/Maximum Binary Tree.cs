// 654. Maximum Binary Tree

using System;

namespace LeetCodeDemo.Tree {
    class Maximum_Binary_Tree {
        public static TreeNode ConstructMaximumBinaryTree(int[] nums) {
            return Helper(nums, 0, nums.Length - 1);
        }

        private static TreeNode Helper(int[] nums, int start, int end) {
            if (start > end) return null;
            if (start == end) return new TreeNode(start);
            int max = Int32.MinValue;
            int maxIndex = 0;
            for (int i = start; i <= end; i++) {
                if(nums[i] > max) {
                    max = nums[i];
                    maxIndex = i;
                }
            }
            TreeNode node = new TreeNode(max);
            node.left = Helper(nums, start, maxIndex - 1);
            node.right = Helper(nums, maxIndex + 1, end);
            return node;
        }
    }
}
