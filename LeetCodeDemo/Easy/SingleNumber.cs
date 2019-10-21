using System.Collections;

// Given a non-empty array of integers, every element appears twice except for one.
// Find that single one.
//Example 1:
//    Input: [2,2,1]
//    Output: 1

//Example 2:
//    Input: [4,1,2,1,2]
//    Output: 4

namespace LeetCodeDemo.Easy
{
    class SingleNumber
    {
        public static int SingleNum(int[] nums)
        {
            Hashtable keyValuePair = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!keyValuePair.ContainsKey(nums[i]))
                {
                    keyValuePair.Add(nums[i], 1);
                }
                else
                {
                    keyValuePair[nums[i]] = keyValuePair[nums[i]].GetHashCode() + 1;
                }
            }

            foreach (int key in keyValuePair.Keys)
            {
                if ((int) keyValuePair[key] == 1) return key;
            }

            return 0;
        }
    }
}
