using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    //Approach 2
    //TC O(n)
    //SC O(1)

    internal class Subarray_Product_Less_Than_K
    {

        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {

            if (k <= 1){
                return 0;
            }
            int left = 0; int right = 0;
            int count = 0;
            int subArray = 1;
            while (right < nums.Length)
            {
                subArray *= nums[right];
                while (subArray >= k)
                {
                    subArray /= nums[left];
                    left++;
                }
                if(subArray < k)
                {
                    count += right - left + 1;
                    right++;
                }
               
            }
            return count;
        }
       /* static void Main(string[] args)
        {

            Subarray_Product_Less_Than_K obj = new Subarray_Product_Less_Than_K();
            int[] nums = { 10,5,2,6 };
            int k = 110; 
            Console.WriteLine(obj.NumSubarrayProductLessThanK(nums, k));

        }*/
    }

    //Approach 1
    //TC O(n^2)
    //SC O(1)
    /* internal class Subarray_Product_Less_Than_K
     {

         public int NumSubarrayProductLessThanK(int[] nums, int k)
         {
             int count = 0;
             for (int i = 0; i < nums.Length; i++)
             {
                 int sum = 1;
                 for (int j = i; j < nums.Length; j++)
                 {
                     sum *= nums[j];
                     if (sum < k)
                     {
                         count++;
                     }
                     else
                     {
                         break;
                     }

                 }
             }
             return count;
         }
         static void Main(string[] args)
         {

             Subarray_Product_Less_Than_K obj = new Subarray_Product_Less_Than_K();
             int[] nums = { 10, 9, 10, 4, 3, 8, 3, 3, 6, 2, 10, 10, 9, 3 };
             int k = 19; //ans 18
             Console.WriteLine(obj.NumSubarrayProductLessThanK(nums, k));

         }
     }*/

}
