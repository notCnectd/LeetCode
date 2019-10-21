// 1026. Maximum Difference Between Node and Ancestor

namespace LeetCodeDemo.Tree {
    class Maximum_Difference_Between_Node_and_Ancestor {
        int diff = 0;
        public int MaxAncestorDiff(TreeNode root) {
            Helper(root, root.val, root.val);
            return diff;
        }

        public void Helper(TreeNode root, int max, int min) {
            if (root == null) return;
            max = max > root.val ? max : root.val;
            min = min < root.val ? min : root.val;
            if (root.left == null && root.right == null)
                diff = diff > max - min ? diff : max - min;
            Helper(root.left, max, min);
            Helper(root.right, max, min);

        }
    }
}
