// 633. Sum of Square Numbers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Easy
{
    class SumofSquareNumbers
    {
        // 圆心在原点的圆的坐标轴表示 a^2 + b^2 = c
        public static bool JudgeSquareSum(int c)
        {
            if (c == 0 || c == 1) return true;
            double r = Math.Sqrt(c);
            for (int i = 0; i * i < c; i++)
            {
                // 查找是否有一整数b存在
                double b = Math.Sqrt(c - i * i);
                if (b - (int)b < Double.Epsilon) return true;
            }
            return false;
        }
    }
}
