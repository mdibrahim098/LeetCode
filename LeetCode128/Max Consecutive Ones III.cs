using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    // Approach 2
    // TC O(n)
    //SC O(1)
    internal class Max_Consecutive_Ones_III
    {

        public int LongestOnes(int[] nums, int k)
        {
            int left = 0;
            int right;
            int maxLength = 0;
            int count = 0;
             for(right=0;right<nums.Length; right++)
            {
                if (nums[right] == 0)
                {
                    count++;
                    while (count > k)
                    {
                        if (nums[left] == 0)
                        {
                            count--;
                        }
                        left++;
                    }
                }
                maxLength = Math.Max(maxLength, right-left+1);
            }
            return maxLength;
        }
       /* static void Main(string[] args)
        {
            Max_Consecutive_Ones_III obj = new Max_Consecutive_Ones_III();

            int[] nums = { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 };
            int k = 3;
            Console.WriteLine(obj.LongestOnes(nums, k));
        }*/
    }

    /*// Approach 1
    // TC O(n^2)
    //SC O(1)
    internal class Max_Consecutive_Ones_III
    {

        public int LongestOnes(int[] nums, int k)
        {
            int maxLength = 0;
            
            for(int i=0; i<nums.Length; i++)
            {
                int count = 0;
                for(int j=i; j<nums.Length; j++)
                {
                    if (nums[j] == 0)
                    {
                        count++;
                        if(count > k)
                        {
                            break;
                        }
                    }
                    maxLength = Math.Max(maxLength, j-i+1);
                }
            }
            return maxLength;
        }
        static void Main(string[] args)
        {
            Max_Consecutive_Ones_III obj = new Max_Consecutive_Ones_III();

          int[]  nums = { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 };
        int k = 3;
            Console.WriteLine(obj.LongestOnes(nums,k));
        }
    }*/
}
