//119. Pascal's Triangle IIusing System;

using System.Collections.Generic;

namespace LeetCodeDemo.Easy {
    class Pascal_s_Triangle_II {
        public IList<int> GetRow(int rowIndex) {
            int[] res = new int[rowIndex + 1];
            for (int i = 0; i <= rowIndex; i++) {
                for (int j = i; j >= 0; j--) {
                    if (j == 0 || j == i)
                        res[j] = 1;
                    else
                        res[j] = res[j] + res[j - 1];
                }
            }
            return res;
        }
    }
}
