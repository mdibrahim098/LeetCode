using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{


   //Approach 2
   // Time Complexity O(n)
   // Space Complexity O(1)
        internal class MaximumSubarray
        {
            public int MaxSubArray(int[] nums)
            {
            int maxSum = nums[0];
            int sum = 0;
            for(int i=0; i<nums.Length; i++)
            {
                sum+= nums[i];
              //  If the current value(nums[i]) is greater than
              //  the sum before it, it means that not all the
              //  elements before it are part of the maximum subarray. 
                if (nums[i] > sum)
                {
                    sum = nums[i]; 
                    
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
               
            }

            return maxSum;
        }

        /*
            static void Main(string[] args)
            {
                MaximumSubarray obj = new MaximumSubarray();
                int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
                Console.WriteLine(obj.MaxSubArray(nums));


            }

        */
        }


    /*
    //Approach 1
    // Time Complexity O(n^2)
    // Space Complexity O(1)
    internal class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            int max = int.MinValue;
            for(int i=0; i<nums.Length; i++)
            {
                int sum = 0;
                for(int j=i; j<nums.Length; j++)
                {
                    sum += nums[j];
                    max = Math.Max(max, sum);

                }
            }
            return max;

        }

        static void Main(string[] args)
        {
            MaximumSubarray obj = new MaximumSubarray();
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.WriteLine(obj.MaxSubArray(nums));


        }
    }
    */

}
