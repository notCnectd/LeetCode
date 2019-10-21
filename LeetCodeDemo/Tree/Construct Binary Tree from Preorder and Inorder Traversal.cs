// 105. Construct Binary Tree from Preorder and Inorder Traversal

namespace LeetCodeDemo.Tree {
    class Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal {
        public TreeNode BuildTree(int[] preorder, int[] inorder) {
            return Helper(preorder, 0, inorder, 0, inorder.Length - 1);
        }

        private TreeNode Helper(int[] preorder, int preStarr, int[] inorder, int inStarr, int inEnd) {
            if (inStarr > inEnd) return null;
            TreeNode root = new TreeNode(preorder[preStarr]);
            int i = inStarr;
            for(; i <= inEnd; i++) {
                if (root.val == inorder[i]) break;
            }
            root.left = Helper(preorder, preStarr + 1, inorder, inStarr, i-1);
            root.right = Helper(preorder, preStarr + 1 + i - inStarr, inorder, i + 1, inEnd);
            return root;
        }
    }
}
