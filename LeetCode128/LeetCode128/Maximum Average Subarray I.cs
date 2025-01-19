using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode128
{


    class Maximum_Average_Subarray_I
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            int n = nums.Length;
            double maxAvg = int.MinValue;
            int left = 0;
            int right = 0;
           double sum=0.0;
           
            while (right < n)
            {
                sum += nums[right];
                if (right - left + 1 == k)
                {
                    sum -= nums[left];
                    left--;
                }
                right++;
                 double avg = (sum / k);
                maxAvg = Math.Max(maxAvg, avg);
            }

   return maxAvg;
        }
        //static void Main(string[] args)
        //{
        //    Maximum_Average_Subarray_I obj = new Maximum_Average_Subarray_I();
        //    int[] nums = { 1, 12, -5, -6, 50, 3 };
        //    int k = 4;
        //    Console.WriteLine(obj.FindMaxAverage(nums, k));
        //    Console.ReadLine();
        //}
    }

    //approach 1
    // TC O(n^2)
    //SC O(1)
    //class Maximum_Average_Subarray_I
    //{
    //    public double FindMaxAverage(int[] nums, int k)
    //    {
    //        double maxAvg = int.MinValue;
    //        for (int i = 0; i < nums.Length - k + 1; i++)
    //        {
    //            double sum = 0;
    //            for (int j = i; j < i + k; j++)
    //            {
    //                sum += nums[j];

    //            }
    //            maxAvg = Math.Max(maxAvg, (double)(sum) / (k));
    //        }
    //        return maxAvg;
    //    }
    //    static void Main(string[] args)
    //    {
    //        Maximum_Average_Subarray_I obj = new Maximum_Average_Subarray_I();
    //        int[] nums = { 1, 12, -5, -6, 50, 3 };
    //        int k = 4;
    //        Console.WriteLine(obj.FindMaxAverage(nums, k));
    //        Console.ReadLine();
    //    }
    //}
}
