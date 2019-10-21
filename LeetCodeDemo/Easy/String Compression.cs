// 443. String Compression

namespace LeetCodeDemo.Easy
{
    class String_Compression
    {
        public static int Compress(char[] chars)
        {
            int front = 0, write = 0, back = 0;
            for (; front < chars.Length; front++)
            {
                if (front + 1 == chars.Length || chars[front] != chars[front + 1])
                {
                    chars[write++] = chars[back];
                    if (front > back)
                    {
                        foreach (char ch in (front - back + 1).ToString())
                            chars[write++] = ch;
                    }
                    back = front + 1;
                }
            }
            return write;
        }
    }
}
