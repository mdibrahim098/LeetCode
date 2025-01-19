using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    // TC O(logn)
    // SC O(1)
    internal class Search_in_Rotated_Sorted_Array
    {

        public int Search(int[] nums, int target)
        {

            int left = 0;
             int right = nums.Length - 1;   
            while(left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[left] <= nums[mid])
                {
                    if (nums[left]<=target && target <= nums[mid])
                    {
                        right = mid ;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else
                {
                    if (nums[mid] <= target && target <= nums[right])
                    {
                        left = mid ;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }
            return -1;

        }
       /* static void Main(string[] args)
        {
            Search_in_Rotated_Sorted_Array obj = new Search_in_Rotated_Sorted_Array();
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            int target = 0;
            Console.WriteLine(obj.Search(nums, target));
        }*/
    }
}
