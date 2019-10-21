// 628.Maximum Product of Three Numbers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Easy
{
    class MaximumProductofThreeNumbers
    {
        public static int MaximumProduct(int[] nums)
        {
            // 使用希尔排序
            int i, j, increment, tmp;
            for (increment = nums.Length / 2; increment > 0; increment /= 2)
            {
                for (i = increment; i < nums.Length; i++)
                {
                    tmp = nums[i];
                    for (j = i; j >= increment; j -= increment)
                    {
                        if (tmp > nums[j - increment]) nums[j] = nums[j - increment];
                        else break;
                    }
                    nums[j] = tmp;
                }
            }
            return (nums[0] * nums[1] * nums[2] > nums[0] * nums[nums.Length - 1] * nums[nums.Length - 2])? nums[0] * nums[1] * nums[2]: nums[0] * nums[nums.Length - 1] * nums[nums.Length - 2];
        }

        public static int[] InsertionSort(int[] nums)
        {
            // 插入排序
            int i, j, tmp;
            for(i = 1; i < nums.Length; i++)
            {
                tmp = nums[i];
                for (j = i; j > 0 && nums[j - 1] < tmp; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[j] = tmp;
            }
            return nums;
        }
    }
}
