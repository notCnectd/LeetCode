// 735. Asteroid Collision


namespace LeetCodeDemo.Medium
{
    class Asteroid_Collision
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            int[] stack = new int[asteroids.Length];
            int i = 0, top = -1;
            for(; i < asteroids.Length; i++)
            {
                if (top == -1 || isSameSign(stack[top], asteroids[i]))
                    stack[++top] = asteroids[i];
                while (top > -1 && !isSameSign(stack[top], asteroids[i]))
                {
                    if(stack[top] < 0)
                    {
                        stack[++top] = asteroids[i];
                        break;
                    }
                    else
                    {
                        if (stack[top] > -asteroids[i]) break;
                        else if(stack[top] == -asteroids[i])
                        {
                            --top;
                            break;
                        }
                        else
                        {
                            while (top > -1 && stack[top] > 0 && stack[top] < -asteroids[i])
                                top--;
                            if(top == -1)
                            {
                                stack[++top] = asteroids[i];
                                break;
                            }
                            if (stack[top] < 0) stack[++top] = asteroids[i];
                        }
                    }
                }
            }
            int[] res = new int[top + 1];
            for (i = 0; i <= top; i++) res[i] = stack[i];
            return res;
        }

        bool isSameSign(int num1, int num2) => ((num1 > 0 && num2 > 0) || (num1 < 0 && num2 < 0)) ? true : false;
    }
}
