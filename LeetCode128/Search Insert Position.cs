using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{




    internal class Search_Insert_Position1
    {



        // TC O(n)
        //SC O(1)
        public int SearchInsert(int[] nums, int target)
        {
            int k = 0;
            for(int i = 0;i<nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }
                else if (nums[i] < target)
                {
                    k++;
                    continue;

                }
                else
                {
                    return i;
                }
            }
            return k;
        }
      /*  static void Main(string[] args)
        {
            Search_Insert_Position1 obj = new Search_Insert_Position1();

            int[] nums = { 1, 3, 5, 6 };
            int target = 2;
            Console.WriteLine(string.Join(" ", obj.SearchInsert(nums, target)));



        }*/

    }
    internal class Search_Insert_Position
    {



        // TC O(logn)
        //SC O(1)
        public int SearchInsert(int[] nums, int target)
        {

            int left = 0;
             int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid]> target)
                {
                    right = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                
            }
            return left;
        }
       /* static void Main(string[] args)
        {
            Search_Insert_Position obj = new Search_Insert_Position();

            int[] nums = { 1, 3, 5, 6 };
            int target = 0;
            Console.WriteLine(string.Join(" ",obj.SearchInsert(nums,target)));



        }*/

    }
}
