using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Asteroid_Collision
    {
        //Each asteroid will be a non-zero integer in the range 
        public int[] AsteroidCollision(int[] asteroids)
        {
            if (asteroids.Length == 0)
                return asteroids;

            Stack<int> stack = new Stack<int>();
            int prev = asteroids[0];
            int absPrev = Math.Abs(asteroids[0]);

            for (int i = 0; i < asteroids.Length; i++)
            {
                int curr = asteroids[i];

                if (stack.Count == 0)
                {
                    stack.Push(curr);
                    continue;
                }

                while (stack.Count != 0 )
                {
                    prev = stack.Pop();
                    absPrev = Math.Abs(prev);
                    int absCurr = Math.Abs(curr);

                    if (prev > 0 && curr < 0)//+ -  (greater lesser)
                    {
                        if (absPrev > absCurr)
                        {

                            stack.Push(prev);
                            // destroy current
                            break;
                        }
                        else if (absPrev == absCurr)
                        {
                            // destroy both
                            break;
                        }
                        else
                        {
                            // destroy prev
                            stack.Push(curr);
                            break;
                        }
                    }
                    else
                    {
                        stack.Push(prev);
                        stack.Push(curr);
                        break;
                    }
                }
            }

            return stack.Reverse().ToArray();
        }
    }
}
