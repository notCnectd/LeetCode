// 56. Merge Intervals

using System.Collections.Generic;
using System.Linq;

namespace LeetCodeDemo.Medium {
    class Merge_Intervals {
        public int[][] Merge(int[][] intervals) {
            //QuickSort(intervals, 0, intervals.Length - 1);
            
            List<int[]> res = new List<int[]>();
            for (int i = 0; i < intervals.Length; i++) {
                if (i == intervals.Length - 1) {
                    res.Add(intervals[i]);
                } else if (intervals[i][1] >= intervals[i + 1][0] && intervals[i][1] <= intervals[i + 1][1]) {
                    intervals[i + 1][0] = intervals[i][0];
                } else if (intervals[i][1] > intervals[i + 1][1]) {
                    intervals[i + 1][0] = intervals[i][0];
                    intervals[i + 1][1] = intervals[i][1];
                } else {
                    res.Add(intervals[i]);
                }
            }
            return res.ToArray();
        }

        public void ShellSort(int[][] intervals) {
            int i, j;
            int increment;
            for (increment = intervals.Length / 2; increment > 0; increment /= 2)
                for (i = increment; i < intervals.Length; i++) {
                    int[] tmp = intervals[i];
                    for (j = i; j >= increment; j -= increment) {
                        if (tmp[0] < intervals[j - increment][0]) {
                            intervals[j] = intervals[j - increment];
                        } else {
                            break;
                        }
                    }
                    intervals[j] = tmp;
                }
        }

        public void InsertionSort(int[][] intervals) {
            int i, j;
            int len = intervals.Length;
            for (i = 1; i < len; i++) {
                int[] tmp = intervals[i];
                for (j = i; j > 0 && intervals[j - 1][0] > tmp[0]; j--) {
                    intervals[j] = intervals[j - 1];
                }
                intervals[j] = tmp;
            }
        }

        public void QuickSort(int[][] intervals, int left, int right) {
            int i, j;
            int[] pivot;
            int cutOff = 3;
            if (left + cutOff <= right) {
                pivot = Median3(intervals, left, right);
                i = left; j = right - 1;
                while (true) {
                    while (intervals[++i][0] < pivot[0]) ;
                    while (intervals[--j][0] > pivot[0]) ;
                    if (i < j)
                        Swap(intervals, i, j);
                    else
                        break;
                }
                Swap(intervals, i, right - 1);
                QuickSort(intervals, left, i - 1);
                QuickSort(intervals, i + 1, right);
            }else {
                InsertionSort(intervals);
            }
        }

        public int[] Median3(int[][] intervals, int left, int right) {
            int center = (left + right) / 2;
            if (intervals[left][0] > intervals[center][0])
                Swap(intervals, left, center);
            if (intervals[left][0] > intervals[right][0])
                Swap(intervals, left, right);
            if (intervals[center][0] > intervals[right][0])
                Swap(intervals, center, right);
            Swap(intervals, center, right - 1);
            return intervals[right - 1];
        }

        public void Swap(int[][] intervals, int i, int j) {
            int[] tmp = intervals[i];
            intervals[i] = intervals[j];
            intervals[j] = tmp;
        }
    }
}
