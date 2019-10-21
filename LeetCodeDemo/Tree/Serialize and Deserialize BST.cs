// 449. Serialize and Deserialize BST

using System.Collections.Generic;
using System.Linq;

namespace LeetCodeDemo.Tree {
    class Codec {

        // Encodes a tree to a single string.
        public string serialize(TreeNode root) {
            // 先序序列
            string res = "";
            if (root == null) return res;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0) {
                TreeNode node = stack.Pop();
                res += node.val + " ";
                if (node.right != null) stack.Push(node.right);
                if (node.left != null) stack.Push(node.left);
            }
            return res;
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data) {
            List<string> preDataStrs = data.Split(' ').ToList();
            preDataStrs.RemoveAt(preDataStrs.Count - 1);
            List<int> preData = new List<int>();
            List<int> inData = new List<int>();
            foreach (string str in preDataStrs) {
                int tmp = int.Parse(str);
                preData.Add(tmp);
                inData.Add(tmp);
            }
            
            inData.Sort();
            return Helper(preData, 0, inData, 0, inData.Count - 1);
        }

        private TreeNode Helper(List<int> preorder, int preStarr, List<int> inorder, int inStarr, int inEnd) {
            if (inStarr > inEnd) return null;
            TreeNode root = new TreeNode(preorder[preStarr]);
            int i = inStarr;
            for (; i <= inEnd; i++) {
                if (root.val == inorder[i]) break;
            }
            root.left = Helper(preorder, preStarr + 1, inorder, inStarr, i - 1);
            root.right = Helper(preorder, preStarr + 1 + i - inStarr, inorder, i + 1, inEnd);
            return root;
        }
    }
}
