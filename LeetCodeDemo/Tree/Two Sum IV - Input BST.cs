// 653.Two Sum IV - Input is a BST


namespace LeetCodeDemo.Tree {
    class Two_Sum_IV___Input_BST {
        //public static bool FindTarget(TreeNode root, int k)
        //{
        //    if (root == null) return false;
        //    ArrayList exsited = new ArrayList();
        //    Stack<TreeNode> stack = new Stack<TreeNode>();
        //    stack.Push(root);
        //    while (stack.Count != 0)
        //    {
        //        TreeNode node = stack.Pop();
        //        int sub = k - node.val;             
        //        if (exsited.Contains(sub))
        //            return true;
        //        exsited.Add(node.val);
        //        if (node.right != null) stack.Push(node.right);
        //        if (node.left != null) stack.Push(node.left);              
        //    }
        //    return false;
        //}

        public static bool FindTarget(TreeNode root, int k) {
            return Helper(root, root, k);
        }

        // 二分查找
        public static TreeNode findNode(TreeNode node, int sub) {
            if (node == null) return null;
            if (node.val == sub) return node;
            else if (node.val > sub) return findNode(node.left, sub);
            else return findNode(node.right, sub);
        }

        public static bool Helper(TreeNode node, TreeNode root, int k) {
            if (node == null) return false;
            TreeNode treeNode = findNode(root, k - node.val);
            if (treeNode != null && treeNode != node) return true;
            else return Helper(node.left, root, k) || Helper(node.right, root, k);
        }
    }
}
