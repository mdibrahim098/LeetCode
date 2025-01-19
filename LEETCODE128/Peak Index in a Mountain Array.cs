using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{


    //Approach 1 
    // TC O(log(arr.Length)) 
    // SC O(1)
    internal class Peak_Index_in_a_Mountain_Array
    {

        public int PeakIndexInMountainArray(int[] arr)
        {
            int left = 0;
             int right = arr.Length - 1;
          
            while (left < right)
            {
               int mid = left + (right - left)/2;
                if ( arr[mid] < arr[mid + 1])
                {
                    
                    left = mid+1;
                }
                else
                {
                   
                    right = mid;
                }
                
            }
            return left;
        }

       /* static void Main(string[] args)
        {
            Peak_Index_in_a_Mountain_Array obj = new Peak_Index_in_a_Mountain_Array();

            int[] arr = { 0, 10,6, 5,4,3, 2 };
            Console.WriteLine(obj.PeakIndexInMountainArray(arr));
        }*/

    }

    //Approach 1 
    // TC O(n) 
    // SC O(1)
    /* internal class Peak_Index_in_a_Mountain_Array
     {

         public int PeakIndexInMountainArray(int[] arr)
         {
             int max = 0;
            int index = -1;
             for(int i=0; i<arr.Length; i++)
             {
                 if (arr[i] > max)
                 {
                     max = Math.Max(max, arr[i]);
                     index = i;
                 }


             }
             return index;
         }

         static void Main(string[] args)
         {
             Peak_Index_in_a_Mountain_Array obj = new Peak_Index_in_a_Mountain_Array();

            int []  arr = {0, 10, 5, 2};
             Console.WriteLine(obj.PeakIndexInMountainArray(arr));
         }

     }*/


}
