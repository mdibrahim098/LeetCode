using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{


    internal class Find_Minimum_in_Rotated_Sorted_Array
    {
        //TC O(logn)
        // SC O(1)
        public int FindMin(int[] nums)
        {
            int left = 0; 
             int right = nums.Length - 1;
            int min = int.MaxValue;
             while (left <= right)
            {
                 int mid = left + (right - left)/2;
                if (nums[left] <= nums[mid])
                {
                    min = Math.Min(min, nums[left]);
                    left = mid + 1;
                }
                else
                {
                    min = Math.Min(min, nums[mid]);
                    right = mid - 1;
                }
            }
             return min;
        }
       /* static void Main(string[] args)
        {
            Find_Minimum_in_Rotated_Sorted_Array obj = new Find_Minimum_in_Rotated_Sorted_Array();
            int[] nums = { 3, 4, 5, 1, 2 };
            Console.WriteLine(obj.FindMin(nums));

        }*/

    }

    // Approach 1
    // TC O(n)
    //SC O(1)
    /* internal class Find_Minimum_in_Rotated_Sorted_Array
     {
         public int FindMin(int[] nums)
         {
             int min = int.MaxValue;
             for(int i = 0; i<nums.Length; i++)
             {
                 min = Math.Min(min, nums[i]);

             }
             return min;
         }
         static void Main(string[] args)
         {
             Find_Minimum_in_Rotated_Sorted_Array obj = new Find_Minimum_in_Rotated_Sorted_Array();
             int[] nums = {3, 4, 5, 1, 2};
             Console.WriteLine(obj.FindMin(nums));

         }

     }*/
}
