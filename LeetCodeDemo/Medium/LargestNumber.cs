// 179. Largest Number
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Medium
{
    class LargestNumber
    {
        public static string Largest_Number(int[] nums)
        {
            string result = "";
            nums = ShellSort(nums);
            if (nums[0] == 0) return "0";
            for(int i = 0; i < nums.Length; i++)
            {
                result += nums[i];
            }
            return result;
        }

        public static bool IsGreater(string num1, string num2)
        {         
            if (num1 == num2) return false;
            int i = 0, j = 0;
            while (true)
            {
                if (num1[i] > num2[j]) return true;
                if (num1[i] < num2[j]) return false;
                if (num1[i] == num2[j])
                {
                    if (i + 1 < num1.Length) i++;
                    if (j + 1 < num2.Length) j++;
                }
                if (i < j)
                {                    
                    for(; j < num2.Length; j++)
                    {
                        for (int k = 0; k < num1.Length; k++)
                        {
                            if (num1[k] < num2[j]) return false;
                            if (num1[k] > num2[j]) return true;
                        }
                    }                    
                    return false;
                }
                if (i > j)
                {
                    for (; i < num1.Length; i++)
                    {
                        for (int k = 0; k < num2.Length; k++)
                        {
                            if (num1[i] < num2[k]) return false;
                            if (num1[i] > num2[k]) return true;
                        }
                    }
                    return false;
                }
                
            }
        }

        public static int[] ShellSort(int[] nums)
        {
            int increment = nums.Length / 2;
            int i, j, tmp;
            for (; increment > 0; increment /= 2)
            {
                for (i = increment; i < nums.Length; i++)
                {
                    tmp = nums[i];
                    for (j = i; j >= increment; j -= increment)
                    {
                        if (IsGreater(tmp.ToString(), nums[j - increment].ToString())) nums[j] = nums[j - increment];
                        else break;
                    }
                    nums[j] = tmp;
                }
            }
            return nums;
        }
    }
}
