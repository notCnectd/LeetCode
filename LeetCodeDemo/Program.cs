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
            int[] arr = { 5, 7, 7, 8, 8, 10 };
            int[] a2 = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

            //Console.WriteLine();
            //Median_of_Two_Sorted_Arrays.FindMedianSortedArrays(arr, a2);
            //Console.Write(Longest_Substring_Without_Repeating_Characters.LengthOfLongestSubstring("dvdf"));
            int[][] matrix = new int[][]{
                new int[] {-1 },
                new int[] { 3,2 },
                new int[] {1,-2,-1},
                //new int[] { 8, 9 },
                //new int[] { 1, 10 }

            };
            bool[][] dp = new bool[1][];
            
           
            
            Console.ReadLine();
            
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
