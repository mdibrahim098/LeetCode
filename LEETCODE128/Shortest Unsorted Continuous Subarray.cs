using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    //TC O(n)
    //SC O(1)
    class Shortest_Unsorted_Continuous_Subarray
    {
         public int FindUnsortedSubarray(int[] nums) {
        int low =0; int high= nums.Length-1;
        while(low+1<= nums.Length-1 && nums[low]<=nums[low+1] ){
            low++;

        }
        while(high-1>=0 && nums[high]>=nums[high-1]){
            high--;
        }
        if(low>=nums.Length-1){
            return 0;
        }
        int min = int.MaxValue;
        int max = int.MinValue;
        for (int i = low; i <=high; i++)
        {
            min = Math.Min(min, nums[i]);
            max = Math.Max(max, nums[i]);
        }
        while (low - 1 >= 0 && nums[low - 1] > min)
        {
            low--;
        }
        while (high + 1 <= nums.Length - 1 && nums[high + 1] < max)
        {
            high++;
        }
        return high - low + 1;
    }
         //static void Main(string[] args)
         //{
         //    Shortest_Unsorted_Continuous_Subarray obj = new Shortest_Unsorted_Continuous_Subarray();
         //   int[] nums = {2,6,4,8,10,9,15};
         //   Console.WriteLine(obj.FindUnsortedSubarray(nums));
         //   Console.ReadLine();
         //}

    }
}
