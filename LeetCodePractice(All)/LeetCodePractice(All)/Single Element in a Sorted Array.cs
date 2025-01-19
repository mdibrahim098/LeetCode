using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice_All_
{
    internal class Single_Element_in_a_Sorted_Array
    {
        //TC O(logn)
        //SC O(1)
        public int SingleNonDuplicate(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            if (nums.Length == 1)
            {
                return nums[right];
            }
            // if the unique element is the first or last element of the array

            if (nums[left] != nums[left + 1])
            {
                return nums[left];
            }

            // if the unique element is the last element of the array
            if (nums[right] != nums[right - 1])
            {
                return nums[right];
            }

            while (right >= left)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid - 1] != nums[mid] && nums[mid] != nums[mid + 1])
                {
                    return nums[mid];
                }

                // left or right side total elements even/odd check 
                // if even then no need to check 
                if (nums[mid - 1] == nums[mid])
                {
                    int countLeft = mid - left + 1;
                    if (countLeft % 2 == 0)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 2;
                    }
                }

                if (nums[mid] == nums[mid + 1])
                {
                    int countRight = right - mid + 1;
                    if (countRight % 2 == 0)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 2;
                    }
                }
            }
            return -1;
        }

      /*  static void Main(string[] args)
        {
            Single_Element_in_a_Sorted_Array obj = new Single_Element_in_a_Sorted_Array();
            int[] nums = { 1, 1, 2, 3, 3, 4, 4, 8, 8 };
            Console.WriteLine(obj.SingleNonDuplicate(nums));


        }*/
    }
}
