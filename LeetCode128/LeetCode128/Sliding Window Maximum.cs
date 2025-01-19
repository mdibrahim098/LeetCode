using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode128
{
    class Sliding_Window_Maximum
    {

      
        public int[] MaxSlidingWindow(int[] nums, int k)
        {

            int n = nums.Length;

            int[] result = new int[n - k + 1];
            for (int i = 0; i < n - k; i++)
            {
                int max = int.MinValue;
                for (int j = i; j < i + k - 1; j++)
                {
                    max = Math.Max(nums[j], max);

                }
                result[i] = max;
            }
            return result;

        }
        static void Main(string[] args)
        {

            Sliding_Window_Maximum obj = new Sliding_Window_Maximum();
            int[] nums = {1,3,-1,-3,5,3,6,7};
            int k = 3;
            Console.WriteLine(string.Join(",", obj.MaxSlidingWindow(nums, k)));
            Console.ReadLine();
        }
    }
}
