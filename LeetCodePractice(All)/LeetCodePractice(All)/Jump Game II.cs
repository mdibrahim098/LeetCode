using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice_All_
{
    //TC O(n)
    //SC O(1)
    internal class Jump_Game_II
    {

        public int Jump(int[] nums)
           
        {
            if (nums.Length == 1)
            {
                return 0;
            }
                int totalJump = 0;
            int destination = nums.Length-1;
            int lastPosition = 0;
            int coverage = 0;
            for(int i=0; i<nums.Length; i++)
            {
                coverage = Math.Max(coverage, i + nums[i]);
                if (i == lastPosition)
                {
                    lastPosition = coverage;
                    totalJump++;
                    if (coverage >= destination)
                    {
                        return totalJump;

                    }
                }
               

            }
            return totalJump;
        }
       /* static void Main(string[] args)
        {
            Jump_Game_II obj = new Jump_Game_II();
            int[] nums = {2,4,1,2,3,1,1,2};
            Console.WriteLine(obj.Jump(nums));

        }*/
    }
}
