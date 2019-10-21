// 124. Binary Tree Maximum Path Sum

namespace LeetCodeDemo.Tree {
    class Binary_Tree_Maximum_Path_Sum {
        // 设置全局变量存储最大值
        static int max = int.MinValue;

        public static int MaxPathSum(TreeNode root) {
            Helper(root);
            return max;
        }

        // 递归，主要作用是为了更新max的值
        public static int Helper(TreeNode root) {
            if (root == null) return 0;         
            int leftGain = root.val + Helper(root.left);
            int rightGain = root.val + Helper(root.right);
            if (leftGain > max) max = leftGain;
            if (rightGain > max) max = rightGain;
            if (root.val > max) max = root.val;
            if (leftGain + rightGain - root.val > max)
                max = leftGain + rightGain - root.val;
            // 判断返回值，不需要考虑max，只需要选取当前子树的最优路径
            if (leftGain < root.val && rightGain < root.val)
                return root.val;
            else
                return (leftGain > rightGain) ? leftGain : rightGain;
            
        }
    }
}
