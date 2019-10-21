// 508. Most Frequent Subtree Sum

using System.Collections;
using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Most_Frequent_Subtree_Sum {
        public int[] FindFrequentTreeSum(TreeNode root) {
            Hashtable ht = new Hashtable();
            Helper(root, ht);
            int max = int.MinValue;
            foreach (int key in ht.Keys) {
                max = max > (int)ht[key] ? max: (int)ht[key];
            }
            List<int> res = new List<int>();
            foreach(int key in ht.Keys) {
                if(max == (int)ht[key]) {
                    res.Add(key);
                }
            }
            return res.ToArray(); 
        }

        private int Helper(TreeNode root, Hashtable ht) {
            if (root == null) {
                return 0;
            }
            int num = root.val + Helper(root.left, ht) + Helper(root.right, ht);
            if (!ht.ContainsKey(num)) {
                ht.Add(num, 1);
            } else {
                ht[num] = (int)ht[num] + 1;
            }
            return num;
        }
    }
}
