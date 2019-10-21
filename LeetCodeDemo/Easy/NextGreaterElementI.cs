// 496. Next Greater Element I

using System.Collections;
using System.Collections.Generic;

namespace LeetCodeDemo.Easy
{
    class NextGreaterElementI
    {
        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            Hashtable hs = new Hashtable();
            Stack<int> stack = new Stack<int>();
            if(nums2.Length > 0) stack.Push(nums2[0]);
            int i;
            for(i = 1; i < nums2.Length; i++)
            {
                while(stack.Count != 0 && nums2[i] > stack.Peek())
                    hs.Add(stack.Pop(), nums2[i]);
                stack.Push(nums2[i]);
            } 
            for(i = 0; i < nums1.Length; i++)
            {
                if (hs.ContainsKey(nums1[i])) nums1[i] = (int)hs[nums1[i]];
                else nums1[i] = -1;
            }
            return nums1;
        }
    }
}
