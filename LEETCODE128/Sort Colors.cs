using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{





    // Approach 3
    // TC O(n)
    // SC O(1)
     internal class Sort_Colors
     {

         public void SortColors(int[] nums)
         {
            int left = 0;
            int right = nums.Length - 1;
            int mid = 0;
            int temp = 0;
            while (mid<= right)
            {

                if (nums[mid] == 0)
                {

                    temp = nums[left];
                    nums[left] = nums[mid];
                    nums[mid] = temp;
                    mid++;
                    left++;
                }
                else if (nums[mid] == 2)
                {
                    temp = nums[right];
                    nums[right] = nums[mid];
                    nums[mid] = temp;
                    right--;


                }
                else
                {
                    mid++;

                }
            }
                Console.WriteLine(string.Join(",",nums));
        }
         /*static void Main(string[] args)
         {
             Sort_Colors obj = new Sort_Colors();
             int[] nums = { 2, 0, 2, 1, 1, 0};
             obj.SortColors(nums);

         }*/
     }

    // Approach 2(Merge sort)
    // TC O(nlogn)
    // SC O(n)
    /* internal class Sort_Colors
     {

         public void SortColors(int[] nums)
         {
            devide(nums,0,nums.Length-1);
             Console.WriteLine(string.Join(",", nums));

         }
         static void devide(int[] nums, int start, int end)
         {
             if (start >= end) return;


             int mid = start + (end - start) / 2;
             devide(nums, start, mid);

             devide(nums, mid + 1, end);
             conquer(nums, start, mid, end);

         }

         static void conquer(int[] nums, int start,int mid, int end)
         {
             int[] merge = new int[end-start +1];
             int id1 = start;
             int id2 = mid + 1;
             int x = 0;
             while(id1<= mid && id2 <= end)
             {
                 if (nums[id1] > nums[id2])
                 {
                     merge[x++] = nums[id2++];
                 }
                 else
                 {
                     merge[x++] = nums[id1++];
                 }
             }

             while(id1 <= mid)
             {
                 merge[x++] = nums[id1++];
             }
             while (id2 <= end)
             {
                 merge[x++] = nums[id2++];
             }

             for(int i=0, j=start; i< merge.Length; i++, j++)
             {
                 nums[j] = merge[i];
             }
         }



         static void Main(string[] args)
         {
             Sort_Colors obj = new Sort_Colors();
             int[] nums = { 2, 0, 2, 1, 1, 0 };
             obj.SortColors(nums);

         }
     }
 */

    // Approach 1(Bubble sort)
    // TC O(n^2)
    // SC O(1)
    /* internal class Sort_Colors
     {

         public void SortColors(int[] nums)
         {

             for(int i=0; i<nums.Length-1; i++)
             {
                  for(int j=i+1;j<nums.Length; j++)
                 {
                     if (nums[i] > nums[j])
                     {
                         int temp = nums[i];
                         nums[i] = nums[j];
                         nums[j] = temp;
                     }

                 }
             }
           

         }
         static void Main(string[] args)
         {
             Sort_Colors obj = new Sort_Colors();
             int[] nums = { 2, 0, 2, 1, 1, 0};
             obj.SortColors(nums);

         }
     }*/
}
