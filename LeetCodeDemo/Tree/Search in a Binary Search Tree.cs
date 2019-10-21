// 700. Search in a Binary Search Tree

namespace LeetCodeDemo.Tree
{
    class Search_in_a_Binary_Search_Tree
    {
        // Non-recursive
        //public TreeNode SearchBST(TreeNode root, int val)
        //{
        //    if (root.val == val) return root;
        //    TreeNode node = root;
        //    while (node != null)
        //    {
        //        if (node.val == val) return node;
        //        else if (node.val < val)
        //            node = node.right;
        //        else
        //            node = node.left;
        //    }
        //    return null;
        //}

        public static TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null) return null;
            if (root.val == val) return root;
            else if (root.val > val) return SearchBST(root.left, val);
            else return SearchBST(root.right, val);
        }
    }
}
