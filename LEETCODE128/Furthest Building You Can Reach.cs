using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    class Furthest_Building_You_Can_Reach
    {
        public int FurthestBuilding(int[] heights, int bricks, int ladders)
        {
            int i = 0;
            Queue<int> queue = new Queue<int>();
            for (; i < heights.Length - 1; i++)
            {
                if (heights[i + 1] <= heights[i])
                {
                    continue;

                } 
                int h = heights[i+1] - heights[i];
                if (h <= bricks)
                {
                    bricks -= h;
                    queue.Enqueue(h);

                }
                else if (ladders > 0)
                {
                    int x = queue.Peek();
                    if (x > h)
                    {
                        bricks += x;
                        queue.Dequeue();
                        queue.Enqueue(x);
                        bricks -= h;
                    }
                    ladders--;
                }
                else
                {
                    break;
                }
            }
            return i;
        }
        //static void Main(string[] args)
        //{
        //    Furthest_Building_You_Can_Reach obj = new Furthest_Building_You_Can_Reach();

        //  int[]  heights = {4,2,7,6,9,14,12};
        //  int bricks = 5;
        //    int ladders = 1;
        //    Console.WriteLine(obj.FurthestBuilding(heights,bricks,ladders));
        //    Console.ReadLine();
        //}

    }
}
