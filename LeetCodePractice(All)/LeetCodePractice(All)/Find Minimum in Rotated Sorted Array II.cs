using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice_All_
{
    internal class Find_Minimum_in_Rotated_Sorted_Array_II
    {
        //TC O(logn)
        //SC O(1)
        public int FindMin(int[] nums)
        {
            if(nums.Length== 1)
            {
                return nums[0];
            }
            int min = int.MaxValue;
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
              if(left <nums.Length && nums[left] == nums[left + 1])
                {
                    left++;
                    continue;
                }
                if (left < nums.Length && nums[left] == nums[mid] && left!= mid)
                {
                    left ++;
                    continue;
                }
                if (nums[left]<= nums[mid])
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
      /*  static void Main(string[] args)
        {
            Find_Minimum_in_Rotated_Sorted_Array_II obj = new Find_Minimum_in_Rotated_Sorted_Array_II();
            int[] nums = {2, 2, 2, 0, 1};
            Console.WriteLine(obj.FindMin(nums));

        }*/


    }
}
