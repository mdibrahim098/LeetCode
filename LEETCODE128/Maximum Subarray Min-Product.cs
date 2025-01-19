using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    //Approach 1
    //TC O(n)
    //SC O(n)
    class Maximum_Subarray_Min_Product
    {
        public int MaxSumMinProduct(int[] nums)
        {

            int n = nums.Length;
        long mod = 1000000007;

        // Step 1: Compute prefix sums
        long[] prefix = new long[n + 1];
        for (int i = 0; i < n; i++) {
            prefix[i + 1] = prefix[i] + nums[i];
        }

        // Step 2: Find the range for each element using monotonic stacks
        int[] left = new int[n];
        int[] right = new int[n];
        Stack<int> stack = new Stack<int>();

        // Find next smaller element on the left
        for (int i = 0; i < n; i++) {
            while (stack.Count > 0 && nums[stack.Peek()] >= nums[i]) {
                stack.Pop();
            }
            left[i] = stack.Count == 0 ? 0 : stack.Peek() + 1;
            stack.Push(i);
        }

        stack.Clear();

        // Find next smaller element on the right
        for (int i = n - 1; i >= 0; i--) {
            while (stack.Count > 0 && nums[stack.Peek()] >= nums[i]) {
                stack.Pop();
            }
            right[i] = stack.Count == 0 ? n - 1 : stack.Peek() - 1;
            stack.Push(i);
        }

        // Step 3: Calculate max min-product
        long maxMinProduct = 0;
        for (int i = 0; i < n; i++) {
            long sum = prefix[right[i] + 1] - prefix[left[i]];
            long minProduct = sum * nums[i];
            maxMinProduct = Math.Max(maxMinProduct, minProduct);
        }

        // Step 4: Return the result modulo 10^9 + 7
        return (int)(maxMinProduct % mod);
        }
        //static void Main(string[] args)
        //{
        //    Maximum_Subarray_Min_Product obj = new Maximum_Subarray_Min_Product();
        //    int[] nums = { 1, 2, 3, 2 };
        //    Console.WriteLine(obj.MaxSumMinProduct(nums));
        //    Console.ReadLine();
        //}
    }

     //Approach 1
    //TC O(n^2)
    //SC O(1)
    //class Maximum_Subarray_Min_Product
    //{
    //    public int MaxSumMinProduct(int[] nums)
    //    {

    //        int n= nums.Length;
    //        int max = 0;

    //        for (int i = 0; i < nums.Length; i++)
    //        {
    //            int sum = 0;
    //            int min = nums[i];
    //            for (int j = i; j < n; j++)
    //            {
    //                min = Math.Min(min, nums[j]);
    //                sum += nums[j];

    //            }
    //            max = Math.Max(max, sum * min);
    //        }
    //        return max;
    //    }
    //    static void Main(string[] args)
    //    {
    //        Maximum_Subarray_Min_Product obj = new Maximum_Subarray_Min_Product();
    //        int[] nums = {1,2,3,2};
    //        Console.WriteLine(obj.MaxSumMinProduct(nums));
    //        Console.ReadLine();
    //    }
    //}
}
