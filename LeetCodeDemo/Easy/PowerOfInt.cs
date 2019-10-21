using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Given an integer n, write a function to determine if it is a power of n.

namespace LeetCodeDemo.Easy
{
    class PowerOfInt
    {
        public static bool IsPowerOfThree(int n)
        {
            if (n > 0 && 1162261467 % n == 0)
            {
                return true;
            }
            return false;

            // return (n > 0 && 1162261467 % n == 0)? true : false;
            //if (n <= 0) return false;
            //if (n == 1) return true;
            //return IsPowerOfThree(n / 3) && n % 3 == 0;
        }

        public static bool IsPowerOfFour(int num)
        {
            if (num == 1) return true;
            if (num <= 0) return false;
            string bir = Convert.ToString(num - 1, 2);
            if (!IsEven(bir)) return false;
            for (int i = 0; i < bir.Length; i++)
            {
                if (bir[i] != '1') return false;
            }
            return true;
        }

        public static bool IsEven(string bir)
        {
            if ((bir.Length) % 2 == 0)
            {
                return true;
            }

            return false;
        }

        public static void Test()
        {
            int num = 15;
            Console.WriteLine(Convert.ToString(num, 2));
            Console.ReadKey();
        }

        public static bool IsPowerOfTwo(int n)
        {
            if (n == 1) return true;
            if (n <= 0) return false;
            string bir = Convert.ToString(n - 1, 2);
            for (int i = 0; i < bir.Length; i++)
            {
                if (bir[i] != '1')
                {
                    return false;
                }
            }
            return true;
        }
    }
}

