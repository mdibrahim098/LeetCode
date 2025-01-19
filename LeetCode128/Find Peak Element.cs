using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    //Approach 2
    // TC O(logn)
    //SC O(1)
    internal class Find_Peak_Element
    {
        public int FindPeakElement(int[] nums)

        {

            int  low = 0;
            int high = nums.Length - 1;

            while (low <= high)
            {
                int mid = (high + low) / 2;
               
                   if (mid != nums.Length - 1 && nums[mid + 1] > nums[mid])
                    low = mid + 1;
               else if (mid != 0 && nums[mid - 1] > nums[mid])
                    high = mid - 1;
               
                else
                    return mid;
            }

            return -1;

        }
        /*static void Main(string[] args)
        {
            Find_Peak_Element obj = new Find_Peak_Element();
            int[] nums = { 1, 2};
            Console.WriteLine(obj.FindPeakElement(nums));
        }*/
    }


    //Approach 1
    // TC O(n)
    //SC O(1)
    /* internal class Find_Peak_Element
     {
         public int FindPeakElement(int[] nums)

         {

             if (nums.Length == 1)
             {
                 return 0;
             }
             int j = 0;
             for (int i=1; i<nums.Length; i++)
             {
                 if (nums[j] > nums[i])
                 {
                     return j;
                 }
                 else
                 {
                     j++;    
                     continue;
                 }
             }
             return j;
         }
         static void Main(string[] args)
         {
             Find_Peak_Element obj = new Find_Peak_Element();
             int[] nums = { 1, 2, 3, 4 };
             Console.WriteLine(obj.FindPeakElement(nums));
         }
     }*/

}
