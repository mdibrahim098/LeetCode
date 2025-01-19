using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    //Approach 2
    //TC O(logn)
    //SC O(1)
    internal class Binary_Search
    {
        public int Search(int[] nums, int target)
        {

            int left = 0;
            int right = nums.Length-1;
            while (left <= right)
            {
                int mid = left + (right - left)/2;

                if (nums[mid] == target)
                {
                    return mid;
                } 
                else if (nums[mid]> target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1; 
                }
            }
            return -1;

        }
      /*  static void Main(string[] args)
        {
            Binary_Search obj = new Binary_Search();
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            int target = 13;

            Console.WriteLine(obj.Search(nums, target));
        }*/


    }

    //Approach 1 
    //TC O(n)
    //SC O(1)
    /* internal class Binary_Search
     {
         public int Search(int[] nums, int target)
         {

             int i = 0;
             while (i < nums.Length)
             {
                 if (nums[i] == target) return i; 

                 i++;
             }
             return -1;
         }
         static void Main(string[] args)
         {
             Binary_Search obj = new Binary_Search();
             int[] nums = { -1, 0, 3, 5, 9, 12 };
             int target = 9;

             Console.WriteLine(obj.Search(nums,target));
         }


     }*/


}
