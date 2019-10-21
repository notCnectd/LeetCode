// 69. Sqrt(x)

namespace LeetCodeDemo.Easy
{
    class Sqrt
    {
        public static int MySqrt(int x)
        {
            long left = 0;
            long right = x / 2 + 1;
            while (left < right)
            {
                long mid = (left + right + 1) >> 1;
                long tmp = mid * mid;
                if (tmp > x) right = mid - 1;
                else left = mid;
            }
            return (int)left;
        }

        
    }
}
