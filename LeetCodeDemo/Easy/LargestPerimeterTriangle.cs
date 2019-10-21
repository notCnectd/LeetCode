// 976. Largest Perimeter Triangle
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Easy
{
    class LargestPerimeterTriangle
    {
        // 任意两边之和大于第三边，任意两边之差小于第三边
        public static int LargestPerimeter(int[] A)
        {
            // Shell sort
            if (A.Length < 3) return 0;
            if(A.Length > 3)
            {
                int increment = A.Length / 2;
                int i, j, tmp;
                for (; increment > 0; increment /= 2)
                {
                    for (i = increment; i < A.Length; i++)
                    {
                        tmp = A[i];
                        for (j = i; j >= increment; j -= increment)
                        {
                            if (A[j - increment] < tmp) A[j] = A[j - increment];
                            else break;
                        }
                        A[j] = tmp;
                    }

                }
            }           
            for(int k = 0; k < A.Length - 2; k++)
            {
                if (IsTraingle(A[k], A[k + 1], A[k + 2])) return A[k] + A[k + 1] + A[k + 2];
            }
            return 0;
        }

        public static bool IsTraingle(int edge1, int edge2, int edge3)
        {
            return (edge1 + edge2 > edge3 && edge1 + edge3 > edge2 && edge2 + edge3 > edge1) ? true : false;

        }
    }
}
