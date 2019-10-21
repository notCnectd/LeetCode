using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using LeetCodeDemo.Easy;
using LeetCodeDemo.Medium;
using LeetCodeDemo.Hard;
using LeetCodeDemo.Tree;

namespace LeetCodeDemo {
    class Program {
        static void Main(string[] args) {
            //BinaryTree tree = new BinaryTree();

            //TreeNode node = tree.Create();
            int[] arr = { 7, 1, 5, 3, 6, 4 };
            int[] a2 = { 1,1,2};

            //Console.WriteLine();
            //Median_of_Two_Sorted_Arrays.FindMedianSortedArrays(arr, a2);
            //Console.Write(Longest_Substring_Without_Repeating_Characters.LengthOfLongestSubstring("dvdf"));
            int[][] matrix = new int[][]{
                new int[] {4,5 },
                new int[] { 1,4 },
                new int[] {0,1},
                //new int[] { 8, 9 },
                //new int[] { 1, 10 }

            };
            int[][] aaaa = new int[2][];
            Permutations_II p = new Permutations_II();
            p.PermuteUnique(a2);

        }



        public static void reverse(int[] nums, int starr, int end) {
            for (int i = starr, j = end; i < j; i++, j--) {
                int tmp = nums[i];
                nums[i] = nums[j];
                nums[j] = tmp;
            }
        }
    }
}
