using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice_All_
{
    internal class MergeSort
    {

        //TC O(logn)
        // SC O(n)
        // conquer part
        static void conquer(int[] arr, int start, int mid, int end)
        {
            int[] merged = new int[end - start + 1];
            int idx1 = start;
            int idx2 = mid + 1;
            int x = 0;
            while(idx1 <=mid &&  idx2<= end)
            {
                if (arr[idx1] <= arr[idx2])
                {
                    merged[x++] = arr[idx1++];
                }
                else
                {
                    merged[x++] = arr[idx2++];
                }
            }
            while (idx1 <= mid)
            {
                merged[x++] = arr[idx1++];
            }
            while(idx2 <= end)
            {
                merged[x++]= arr[idx2++];
            }

            for(int i =0 ,j =start; i< merged.Length; i++,j++)
            {
                arr[j] = merged[i];
            }

        }

        // TC O(logn)
        //SC O(1)
        // devide part 
        static void devide(int[] arr, int start, int end)
        {
              if(start >= end)
            {
                return;
            }

            int mid = start + (end - start)/2;
            devide(arr, start, mid);
            devide(arr, mid+1, end);
            conquer(arr, start, mid, end);

        }



      /*static void Main(string[] args)
        {
            int[] arr = {6,3,9,5,2,8 };
            int n = arr.Length -1;
            Console.WriteLine(string.Join(",", arr));
            devide(arr, 0, n); 

             
            for(int i =0; i< arr.Length; i++)
            {
                Console.Write(arr[i] + " ");  
            }
            Console.WriteLine();
        }*/

    }
}
