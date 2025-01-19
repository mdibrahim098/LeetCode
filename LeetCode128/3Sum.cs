using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{


    //TC O(n^2)
    //SC (n)
    internal class _3Sum
    {

        public IList<IList<int>> ThreeSum(int[] nums)
        {

            IList<IList<int>> result = new List<IList<int>>();

            Array.Sort(nums);

            for(int i=0; i<nums.Length-2; i++)
            {
                if(i>0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int low = i + 1;
                int high = nums.Length-1;
                int target = 0 - nums[i];
                while (high > low)
                {
                    if (nums[low] + nums[high] == target)
                    {
                        while(high>low && nums[low] == nums[low + 1])
                        {
                            low++;
                        }
                        while(high >low && nums[high] == nums[high - 1])
                        {
                            high--;
                        }
                        result.Add(new List<int>() { nums[i], nums[low], nums[high] });
                        high--;
                        low++;
                    }
                    else if (nums[low] + nums[high] >target)
                    {
                        high--;
                    }
                    else
                    {
                        low++;

                    }



                }

            }
            return result;
        }
      /*  static void Main(string[] args)
        {
            _3Sum obj = new _3Sum();
            int[] nums = { -1, 0, 1, 2, -1, -4 };
            var results = obj.ThreeSum(nums);

            foreach (var triplet in results)
            {
                Console.WriteLine($"[{string.Join(",",triplet)}]");
            }
        }*/
    }
}
