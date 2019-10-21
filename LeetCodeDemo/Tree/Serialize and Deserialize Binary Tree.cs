// 297. Serialize and Deserialize Binary Tree

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Tree {
    /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
    public class RCodec {



        // Encodes a tree to a single string.
        public string serialize(TreeNode root) {
            string str = "";
            if (root == null) return "#,";
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0) {
                TreeNode node = stack.Pop();
                if (node != null) {
                    str += node.val + ",";
                    stack.Push(node.right);
                    stack.Push(node.left);
                } else {
                    str += "#,";
                }
            }
            return str;
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data) {
            List<string> preData = data.Split(',').ToList();
            preData.RemoveAt(preData.Count - 1);
            if (preData[0] == "#") return null;
            return Helper(preData);
        }

        private TreeNode Helper(List<string> preData) {
            if (preData[0] == "#") {
                preData.RemoveAt(0);
                return null;
            }
            TreeNode node = new TreeNode(int.Parse(preData[0]));
            preData.RemoveAt(0);
            node.left = Helper(preData);
            node.right = Helper(preData);
            return node;
        }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec codec = new Codec();
    // codec.deserialize(codec.serialize(root));
}
