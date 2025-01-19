using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    // Time Complexity O(n);
    // Space Complexity O(1)
    internal class Missingnumber
    {

        public int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            int sum = n * (n + 1) / 2;
            for (int i = 0; i < n; i++)
            {
                sum -= nums[i];
            }
            return sum;

        }
        /*
        static void Main(string[] args)
        {
            Missingnumber obj = new Missingnumber();

            int[] nums = { 3, 0, 1 };
            Console.WriteLine(obj.MissingNumber(nums));


        }
        */
    }

}
