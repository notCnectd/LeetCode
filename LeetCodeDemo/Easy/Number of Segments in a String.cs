// 434. Number of Segments in a String
using System.Linq;

namespace LeetCodeDemo.Easy
{
    class Number_of_Segments_in_a_String
    {
        //public static int CountSegments(string s)
        //{
        //    int count = 0;
        //    int i = 0;
        //    int size = s.Length;
        //    while (i < size)
        //    {
        //        if(s[i] != ' ')
        //        {
        //            while (i < size && s[i] != ' ') i++;
        //            count++;
        //        }
        //        else
        //            while (i < size && s[i] == ' ') i++;
        //    }
        //    return count;
        //}

        public static int CountSegments(string s)
        {
            return s.Split().Count(w => w != string.Empty);
        }
    }
}

