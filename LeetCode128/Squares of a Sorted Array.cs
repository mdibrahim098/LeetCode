using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    //Approach 2
    //TC O(n)
    //SC O(n)
    internal class Squares_of_a_Sorted_Array
    {
        public int[] SortedSquares(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int[] result = new int[nums.Length];
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (Math.Abs(nums[left]) <= Math.Abs(nums[right]))
                {
                    result[i] = nums[right] * nums[right];
                    right--;
                }
                else
                {

                    result[i] = nums[left] * nums[left];

                    left++;

                }
            }
            return result;

        }
      /*  static void Main(string[] args)
        {
            Squares_of_a_Sorted_Array obj = new Squares_of_a_Sorted_Array();

            int[] nums = { -4, -1, 0, 3, 10 };
            Console.WriteLine(string.Join(",", obj.SortedSquares(nums)));
        }*/

    }
    //Approach 1 
    //TC O(nlogn)
    //SC O(1)
    /*  internal class Squares_of_a_Sorted_Array
      {
          public int[] SortedSquares(int[] nums)
          {
              for (int i = 0; i < nums.Length; i++)
              {
                  nums[i] = (int)(Math.Pow(nums[i], 2));
              }
              if (nums.Length == 1)
              {
                  return nums;
              }
              Array.Sort(nums);
              return nums;
          }
          static void Main(string[] args)
          {
              Squares_of_a_Sorted_Array obj = new Squares_of_a_Sorted_Array();

              int[] nums = {-4, -1, 0, 3, 10};
              Console.WriteLine(  string.Join(",", obj.SortedSquares(nums)));
          }

      }*/
}
