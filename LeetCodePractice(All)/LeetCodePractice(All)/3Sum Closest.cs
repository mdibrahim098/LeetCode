using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice_All_
{

    //similar to 2sum
    //TC O(n^2)
    //SC O(1)
    internal class _3Sum_Closest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {

            if (nums.Length == 3)
            {
                return (nums[0] + nums[1] + nums[2]);
            }
            Array.Sort(nums);
            int closestSum = nums[0] + nums[1] + nums[2];
            for(int i=0; i < nums.Length - 2; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (Math.Abs(target - sum) < Math.Abs(target - closestSum))
                    {
                        closestSum = sum;
                    }else if (sum > target)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }
            return closestSum;
        }
      /*  static void Main(string[] args)
        {
            _3Sum_Closest obj = new _3Sum_Closest();
            int[] nums = {8,6,7,3,4,5,-4,-1,-1,2 };
            int target = 1;
            Console.WriteLine(obj.ThreeSumClosest(nums, target));
        }*/
    }
}
