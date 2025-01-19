using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    //TC O(n)
    //SC O(n)
    class Asteroid_Collision
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < asteroids.Length; i++)
            {
                if (stack.Count == 0 || asteroids[i] > 0)
                {
                    stack.Push(asteroids[i]);
                }
                else
                {
                    while (stack.Count != 0)
                    {
                        int top = stack.Peek();
                        if (top < 0)
                        {
                            stack.Push(asteroids[i]);
                            break;
                        }
                        int absVal = Math.Abs(asteroids[i]);
                        if (absVal == top)
                        {
                            stack.Pop();
                            break;
                        }
                        else if (absVal < top)
                        {
                            break;
                        }
                        else
                        {
                            stack.Pop();
                            if (stack.Count == 0)
                            {
                                stack.Push(asteroids[i]);
                                break;
                            }
                        }
                    }
                }
            }
            int[] result = new int[stack.Count];
            for (int i = result.Length-1; i >= 0; i--)
            {
                result[i] = stack.Pop();
            }
            return result;

            }

        //static void Main(string[] args)
        //{
        //    Asteroid_Collision obj = new Asteroid_Collision();
        //    int[] asteroids = { 5, 10, -5 };
        //    Console.WriteLine(string.Join(",", obj.AsteroidCollision(asteroids)));
        //    Console.ReadLine();
        //}

            
   }

}
      
           
        

      
