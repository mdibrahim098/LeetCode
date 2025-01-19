using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    //TC O(2^n)
    // SC O(n)
    class   Hello
    {
        private int ans1 = 0;
        public int FindTargetSumWays(int[] nums, int target)
        {
            Find(0, 0, nums, target);
            return ans1;
        }
        public void Find(int index, int ans, int[] nums, int target)
        {
            if (index == nums.Length)
            {
                if (ans == target)
                {
                    ans1++;

                }
                return;

            }
            Find(index + 1, ans + nums[index], nums, target);
            Find(index + 1, ans - nums[index], nums, target);
        }
        //static void Main(string[] args)
        //{
        //    Hello obj = new Hello();
        //    int[] nums = {1,1,1,1,1};
        //    int target = 3;
        //    Console.WriteLine(obj.FindTargetSumWays(nums,target));
        //    Console.ReadKey();


        //}
    }
}
