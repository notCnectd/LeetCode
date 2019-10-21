using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Tree {
    class Same_Tree {
        // Non-recursive
        public static bool IsSameTree2(TreeNode p, TreeNode q) {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            if (p.val != q.val) return false;
            Stack<TreeNode> pStk = new Stack<TreeNode>();
            Stack<TreeNode> qStk = new Stack<TreeNode>();
            pStk.Push(p);
            qStk.Push(q);
            while (pStk.Count > 0 && qStk.Count > 0) {             
                p = pStk.Pop();
                q = qStk.Pop();
                if (p.val != q.val) return false;
                if (p.left != null) pStk.Push(p.left);
                if (q.left != null) qStk.Push(q.left);
                if (pStk.Count != qStk.Count) return false;
                if (p.right != null) pStk.Push(p.right);
                if (q.right != null) qStk.Push(q.right);
                if (pStk.Count != qStk.Count) return false;
            }
            if (pStk.Count != qStk.Count) return false;
            return true;
        }

        // Recursive
        public bool IsSameTree(TreeNode p, TreeNode q) {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            if (p.val != q.val) return false;
            return IsSameTree(p.right, q.right) && IsSameTree(p.left, q.left);
        }

    }
}
