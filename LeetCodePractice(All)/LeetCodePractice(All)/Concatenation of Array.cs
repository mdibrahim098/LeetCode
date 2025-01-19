using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice_All_
{

    // Time Complexity O(n);
    // Space Complexity O(n)
    internal class Concatenation_of_Array
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] result = new int[nums.Length *2];  
            
            for(int i=0; i<nums.Length; i++)
            {
                result[i] = nums[i];
                result[nums.Length +i] = nums[i];
            }
            return result;
        }
       /*
        static void Main(string[] args)
        {
            Concatenation_of_Array obj = new Concatenation_of_Array();
            int[] nums = { 1, 2, 1 };
            Console.WriteLine(string.Join(" ", obj.GetConcatenation(nums)));


        }
       */
    }
}
