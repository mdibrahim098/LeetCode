using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice_All_
{

    // Approach 2
    //Time complexity O(logn)
    // Space Complexity O(1)
    internal class Program
    {

        public int[] SearchRange(int[] nums, int target)
        {
           int first = FirstHelper(nums,target);
            int lastt = LastHelper(nums, target);
            return new int[] {first,lastt };
           


        }
        private int FirstHelper(int[] nums,int target)
        {
            int first = -1;
            int left = 0;
             int right = nums.Length - 1;
            while (right >= left)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid]== target)
                {
                    first = mid;
                    right = mid - 1;

                }
               else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return first;

        }
        private int LastHelper(int[] nums, int target)
        {
            int last = -1;
            int left = 0;
            int right = nums.Length - 1;
            while (right >= left)
            {
                int mid = left + (right -left) / 2;
                if (nums[mid] == target)
                {
                    last = mid;
                    left = mid + 1;
                }
                else if (nums[mid ]> target){
                    right = right - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return last;
        }
        /*
        static void Main(string[] args)
        {
            Program obj = new Program();
            int[] nums = { 5, 7, 7, 8, 8, 10 };
            int target = 8;
            Console.WriteLine(string.Join(" ", obj.SearchRange(nums, target)));

        }
        */
    }
    /*
    // Approach 1 
    //Time complexity O(n)
    // Space Complexity O(1)
    internal class Program
    {

        public int[] SearchRange(int[] nums, int target)
        {
            int first = -1;
            int last = -1;
            for(int i=0; i<nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    if(first == -1)
                    {
                        first = i;
                    }
                    last = i;
                }
            }
            return new int[] { first, last };   

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
           int[]  nums = {5, 7, 7, 8, 8, 10};
        int target = 8;
            Console.WriteLine(string.Join(" ", obj.SearchRange(nums, target)));
            
        }
    }
    */


}
