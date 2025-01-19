using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    //approach 2
    //TC O(n)
    //sc O(n)
    class _132Pattern
    {

        public bool Find132pattern(int[] nums)
        {
            int n = nums.Length;
            int[] min = new int[n];
            min[0]= nums[0];
            for (int i = 1; i < n; i++)
            {
                min[i] = Math.Min(min[i - 1], nums[i]);
            }

            Stack<int> stack = new Stack<int>();
            for (int j = n - 1; j >= 0; j--)
            {
                if (nums[j] > min[j])
                {
                    while (stack.Count != 0 && stack.Peek() <= min[j])
                    {
                        stack.Pop();
                    }

                    if (stack.Count != 0 && stack.Peek() < nums[j])
                    {
                        return true;
                    }
                    stack.Push(nums[j]);
                }
               
            }
            return false;
        }
        //static void Main(string[] args)
        //{
        //    _132Pattern obj = new _132Pattern();
        //    int[] nums = { 3, 5, 0, 3, 4 };
        //    Console.WriteLine(obj.Find132pattern(nums));
        //    Console.ReadLine();
        //}
    }


    //approach 1
    //TC O(n^2)
    //sc O(n)
    //class _132Pattern
    //{

    //    public bool Find132pattern(int[] nums)
    //    {
    //        int n = nums.Length;
    //        int min = nums[0];
    //        for (int j = 1; j < n-1; j++)
    //        {
    //            for (int k = j + 1; k < n; k++)
    //            {
    //                if (nums[k] > min && nums[k] < nums[j])
    //                {
    //                    return true;
    //                }
    //            }
    //            min = Math.Min(min, nums[j]);
    //        }
    //        return false;
    //    }
    //    static void Main(string[] args)
    //    {
    //        _132Pattern obj = new _132Pattern();
    //        int[] nums = { 3, 5, 0, 3, 4 }; 
    //        Console.WriteLine(obj.Find132pattern(nums));
    //        Console.ReadLine();
    //    }
    //}
}
