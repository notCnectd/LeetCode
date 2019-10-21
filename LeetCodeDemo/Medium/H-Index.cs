// 274. H-Index

namespace LeetCodeDemo.Medium {
    class H_Index
    {
        public static int HIndex(int[] citations)
        {
            int increment = citations.Length / 2;
            int i, j, tmp;
            for (; increment > 0; increment /= 2)
            {
                for(i = increment; i < citations.Length; i++)
                {
                    tmp = citations[i];
                    for (j = i; j >= increment; j -= increment)
                    {
                        if (tmp > citations[j - increment]) citations[j] = citations[j - increment];
                        else break;
                    }
                    citations[j] = tmp;
                }
            }
            int num = 0, cit;
            for (i = 0; i < citations.Length; i++)
            {
                cit = citations[i];
                if (num < cit) num++;
                else break;
            }
            return num;
        }
    }
}
