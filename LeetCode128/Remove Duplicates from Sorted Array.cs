using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    //Approach 2
    //TC O(n)
    //Sc O(1)
    internal class Remove_Duplicates_from_Sorted_Array
    {

        public int RemoveDuplicates(int[] nums)
        {
            int i = 0, j = 1;
            while (j < nums.Length)
            {
                if (nums[j] == nums[j - 1]) j++;
                else
                {
                   
                    nums[++i] = nums[j++];
                }
               
            }
           
            return i + 1;

        }
      /*  static void Main(string[] args)
        {
            Remove_Duplicates_from_Sorted_Array obj = new Remove_Duplicates_from_Sorted_Array();


            int[] nums = { 1, 1, 4 };
            Console.WriteLine(obj.RemoveDuplicates(nums));
        }*/
    }



    //Approach 1
    //TC O(n)
    //Sc O(n)
    /* internal class Remove_Duplicates_from_Sorted_Array
     {

         public int RemoveDuplicates(int[] nums)
         {
            HashSet<int> result = new HashSet<int>();


             for (int i = 0; i < nums.Length; i++)
             {
                 if (result.Contains(nums[i]))
                 {
                     continue;
                 }
                 else
                 {

                     result.Add(nums[i]);
                 }
             }
             int[] array = new int[result.Count];
             int k = 0;
            foreach (int i in result)
             {
                 array[k++] = i;
             }
            for(int i=0; i< nums.Length; i++)
             {
                 if (i < array.Length)
                 {
                     nums[i] = array[i];
                 }
                 else
                 {
                     nums[i] = 0;
                 }
             }

             return result.Count;

         }
         static void Main(string[] args)
         {
             Remove_Duplicates_from_Sorted_Array obj = new Remove_Duplicates_from_Sorted_Array();


           int[]  nums = { 1, 1,4 };
             Console.WriteLine(obj.RemoveDuplicates(nums));
         }
     }*/


}
