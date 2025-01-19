using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    //TC O(n^2)
    //SC O(1)
    class Valid_Triangle_Number
    {
        public int TriangleNumber(int[] nums)
        {
            Array.Sort(nums);
            int count = 0;
            int  n = nums.Length;
            for (int i = n - 1; i >= 2; i--)
            {
                int j = 0, k = i - 1;
                while (k > j)
                {
                    if (nums[j] + nums[k] > nums[i])
                    {
                        count += k - j;
                        k--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            return count;
        }
        //static void Main(string[] args)
        //{
        //    Valid_Triangle_Number obj = new Valid_Triangle_Number();
        //    int[] nums = {2,2,3,4};
        //    Console.WriteLine(obj.TriangleNumber(nums));
        //    Console.ReadLine();
        //}
    }
}
