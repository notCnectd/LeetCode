// 754. Reach a Number
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Easy
{
    class ReachaNumber
    {
        // Wrong Anwser!!!!!!!!!
        public static int ReachNumber(int target)
        {
            if (target < 0) target = -target;
            if (target == 0) return 0;
            int result = 0;
            int current = 0;
            bool isMinus = false;
            for (int i = 1; ; i++)
            {
                if (!isMinus)
                {
                    current += i;
                    result++;
                }
                else
                {
                    current -= i;
                    result++;
                }
                if (target - current == 1) isMinus = true;
                else if (current > target && current - target > current) isMinus = true;
                else if (target - current > 1) isMinus = false;
                else if (current > target && current - target < current) isMinus = false;
                if (current == target) break; 
            }
            return result;
        }

        public static int ReachNum(int target)
        {
            if (target < 0) target = -target;
            int result = 0;
            int sum = 0;
            while(sum < target)
            {
                result++;
                sum += result;
            }
            if((sum - target) % 2 != 0)
            {
                if (result % 2 == 0) result += 1;
                else result += 2;
            }
            return result;
        }
    }
}
