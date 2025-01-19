using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{


    internal class Trapping_Rain_Water
    {

      // time complexity  O(n)
    // space complexity  O(n).
        public int trap(int[] height)
        {

            if (height.Length <= 2)
            {
                return 0;
            }
            int n = height.Length;
            int[] left = new int[n];
            int[] right = new int[n];
            left[0] = 0;
            right[n - 1] = 0;
            int count = 0;
            int a = 0;
            int b = 0;
            for (int i = 1; i < n; i++)
            {
                a = Math.Max(height[i - 1], a);
                left[i] = a;
            }
            for (int i = n - 2; i >= 0; i--)
            {
                b = Math.Max(height[i + 1], b);
                right[i] = b;
            }
            for (int i = 0; i < n; i++)
            {
                int area = Math.Min(left[i], right[i]) - height[i];
                if (area >= 0)
                {
                    count += area;
                }
            }
            return count;

        }

      /*  public static void Main(String[] args)
        {
            Trapping_Rain_Water obj = new Trapping_Rain_Water();
            int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            Console.WriteLine(obj.trap(height));
        }*/
    }
    // time complexity  O(n)
    // space complexity  O(n).
  /*  internal class Trapping_Rain_Water
    {
        public int trap(int[] height)
        {
            int[] maxLeft = new int[height.Length];
            int[] maxRight = new int[height.Length];
            maxLeft[0] = height[0];
            maxRight[height.Length - 1] = height[height.Length - 1];
            for (int i = 1; i < height.Length; i++)
            {
                maxLeft[i] = Math.Max(maxLeft[i - 1], height[i]);
            }
            for (int i = height.Length - 2; i >= 0; i--)
            {
                maxRight[i] = Math.Max(maxRight[i + 1], height[i]);
            }
            int result = 0;
            for (int i = 0; i < height.Length; i++)
            {
                result += (Math.Min(maxLeft[i], maxRight[i])) - (height[i]);
            }
            return result;
        }

        public static void Main(String[] args)
        {
            Trapping_Rain_Water obj = new Trapping_Rain_Water();
            int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            Console.WriteLine(obj.trap(height));
        }
    }*/
}
