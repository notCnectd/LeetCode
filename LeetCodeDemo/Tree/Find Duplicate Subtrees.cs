// 652. Find Duplicate Subtrees

using System.Collections;
using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Find_Duplicate_Subtrees {
        public IList<TreeNode> FindDuplicateSubtrees(TreeNode root) {
            IList<TreeNode> res = new List<TreeNode>();
            Hashtable ht = new Hashtable();
            if (root == null) return res;
            Helper(root, res, ht);
            return res;
        }

        private string Helper(TreeNode root, IList<TreeNode> res, Hashtable ht) {
            if (root == null) return "";
            // 树进行结点比较可以序列化成字符串
            string subTree = root.val + Helper(root.left, res, ht) + Helper(root.right, res, ht);
            if (ht.ContainsKey(subTree)) ht[subTree] = (int)ht[subTree] + 1;
            else ht.Add(subTree, 1);
            if ((int)ht[subTree] == 2) res.Add(root);
            return subTree;
        }
    }
}
