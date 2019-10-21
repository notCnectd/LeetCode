// 513. Find Bottom Left Tree Value

using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Find_Bottom_Left_Tree_Value {
        // 迭代
        public static int FindBottomLeftValue1(TreeNode root) {
            // 层次遍历
            TreeNode res = root;
            Queue<TreeNode> que = new Queue<TreeNode>();
            que.Enqueue(root);
            while (que.Count > 0) {
                int size = que.Count;
                res = que.Peek();
                // 用这种方法寻找每一层的最左节点
                while(size-- > 0) {
                    TreeNode node = que.Dequeue();
                    if (node.left != null) {
                        que.Enqueue(node.left);
                    }
                    if (node.right != null) {
                        que.Enqueue(node.right);
                    }
                }
                
            }
            return res.val;
        }

        // 递归
        int res = -1, maxDepth = -1;
        public int FindBottomLeftValue(TreeNode root) {
            
            Helper(root, 0);
            return res;
        }

        public void Helper(TreeNode root, int depth) {
            if (root == null) return;
            Helper(root.left, depth + 1);
            if (depth > maxDepth) {
                maxDepth = depth;
                res = root.val;
            }
            Helper(root.right, depth + 1);
        }
    }
}
