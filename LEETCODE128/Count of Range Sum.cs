using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{



     internal class Count_of_Range_Sum
      {
        /*  public int CountRangeSum(int[] nums, int lower, int upper)
          {  

          }

        static void Main(string[] args)
        {
            Count_of_Range_Sum obj = new Count_of_Range_Sum();
            int[] nums = { -2147483647, 0, -2147483647, 2147483647 };
            int lower = -564, upper = 3864;
            Console.WriteLine(obj.CountRangeSum(nums, lower, upper));
        }*/

    }


    // Approach 2
    // TC O(n^2) 
    // SC O(n)

    /*  internal class Count_of_Range_Sum
      {
          public int CountRangeSum(int[] nums, int lower, int upper)
          {  int n = nums.Length;
    // prefix array algorithm use
    long[] sums = new long[n + 1];
    for (int k = 0; k < n; ++k)
        sums[k + 1] = sums[k] + nums[k];
    int ans = 0;
           int i = 0;
           int j = i+1;
       while(i<n && j <=n){
          if(sums[j] - sums[i] >= lower && sums[j] - sums[i] <= upper){
            ans++;
          }
          if(j==n){
            
            j = i++ +1;
          }
          j++;
       }
    return ans;

          }

          static void Main(string[] args)
          {
              Count_of_Range_Sum obj = new Count_of_Range_Sum();
              int[] nums = { -2147483647, 0, -2147483647, 2147483647 };
              int lower = -564, upper = 3864;
              Console.WriteLine(obj.CountRangeSum(nums, lower, upper));
          }

      }*/


    // Approach 1
    // TC O(n^2) 
    // SC O(1)

    /*  internal class Count_of_Range_Sum
      {
          public int CountRangeSum(int[] nums, int lower, int upper)
          {
              int count = 0;

               for (int i=0; i<nums.Length; i++)
              {
                long min = 0;
                  for (int j=i;j<nums.Length; j++)
                  {
                      min += nums[j];

                      if (lower <= min && min  <= upper)
                      {
                          count++;
                      }
                  }

              }
              return count;

          }

          static void Main(string[] args)
          {
              Count_of_Range_Sum obj = new Count_of_Range_Sum();
              int[] nums = { -2147483647, 0, -2147483647, 2147483647 };
              int lower = -564, upper = 3864;
              Console.WriteLine(obj.CountRangeSum(nums, lower, upper));
          }

      }*/
}
