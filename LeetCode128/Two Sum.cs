using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    internal class Two_Sum
    {


        // Time Complexity O(n)
        // Space Complexity O(n);
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int,int> result = new Dictionary<int,int>();   

            for(int i=0; i< nums.Length; i++)
                
            {

                int num = target - nums[i]; 
                if (result.ContainsKey(num))
                {
                    return new int[] { result[num], i };
                }
                result.Add(nums[i],i);
            }
            return new int[] { };

        }
        /*
        static void Main(string[] args)
        {
            Two_Sum obj = new Two_Sum();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            Console.WriteLine(string.Join(" ", obj.TwoSum(nums, target)));

        }
        */
    }



    /*
    internal class Two_Sum
    {


       // Time Complexity O(n^2)
       // Space Complexity O(1);
        public int[] TwoSum(int[] nums, int target)
        {
            
            for(int i=0; i<nums.Length; i++)
            {
                 for(int j=i+1; j<nums.Length; j++)
                {
                    if (nums[i]+nums[j] == target)
                    {
                        return new int[] { i, j };                    }
                }
            }
            return new int[] { };
        }
        static void Main(string[] args)
        {
            Two_Sum obj = new Two_Sum();
            int[] nums = { 2, 7, 11, 15 }; 
            int target = 9;
            Console.WriteLine(string.Join(" ",obj.TwoSum(nums,target)));

        }
    }
    */
}
