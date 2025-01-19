using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

   

    /*    // Approach 1;
        //TC O(n^2)
        // SC O(1)
        internal class Binary_Subarrays_With_Sum
        {

            public int NumSubarraysWithSum(int[] nums, int goal)
            {
                int count = 0;
                 for(int i=0; i<nums.Length; i++)
                {
                    int sum = 0;
                    for(int j=i; j<nums.Length; j++)
                    {
                        sum += nums[j];
                        if (sum == goal)
                        {
                            count++;

                        }
                        else if(sum>goal)
                        {
                            break; 
                        }
                    }
                }
                 return count;
            }

            static void Main(string[] args)
            {
                Binary_Subarrays_With_Sum obj = new Binary_Subarrays_With_Sum();
                int[] nums = { 1, 0, 1, 0, 1 };
                int goal = 2;
                Console.WriteLine(obj.NumSubarraysWithSum(nums,goal));
            }
        }*/
}
