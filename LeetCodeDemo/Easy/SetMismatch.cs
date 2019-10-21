// 645. Set Mismatch
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Easy
{
    class SetMismatch
    {
        public static int[] FindErrorNums(int[] nums)
        {
            int[] result = new int[2];
            int sum = 0;
            int sum_equal_diff_series = (1 + nums.Length) * nums.Length / 2;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            int sub = sum - sum_equal_diff_series;
            Hashtable hs = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                if(hs[nums[i]] != null)
                {
                    result[0] = nums[i];
                    break;
                }
                hs.Add(nums[i], nums[i]);
            }
            result[1] = result[0] - sub;       
            return result;
        }
    }
}
