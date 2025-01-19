using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    // TC O(n)
    //SC (1)
    internal class Container_With_Most_Water
    {

        public int MaxArea(int[] height)
        {

            int left = 0;
            int right = height.Length-1;
            int max = 0;
            while (left < right)
            {
                int currentArea = Math.Min(height[left], height[right]) * (right - left);

                max = Math.Max(max, currentArea);
                if (height[left] > height[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return max; 
        }
      /*  static void Main(string[] args)
        {

            Container_With_Most_Water obj = new Container_With_Most_Water();
            int[] height = {1, 8, 6, 2, 5, 4, 8, 3, 7};
            Console.WriteLine(obj.MaxArea(height));
        }*/
    }
}
