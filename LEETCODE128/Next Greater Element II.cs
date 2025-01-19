using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    //Approach 1
    //TC O(2n)
    //SC O(n)
    class Next_Greater_Element_II
    {
        public int[] NextGreaterElements(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            Stack<int> stack = new Stack<int>();
            for (int i = 2 * n - 1; i >= 0; i--)
            {
                while (stack.Count != 0 && stack.Peek() <= nums[i % n])
                {
                    stack.Pop();
                }

                if (i < n)
                {
                    if (stack.Count == 0)
                    {
                        result[i] = -1;
                    }
                    else
                    {
                        result[i] = stack.Peek();
                    }
                }
                stack.Push(nums[i % n]);
            }
            return result;

        }
        //static void Main(string[] args)
        //{
        //    Next_Greater_Element_II obj = new Next_Greater_Element_II();

        //    int[] nums = { 1, 2, 3, 4, 3 };
        //    Console.WriteLine(string.Join(",", obj.NextGreaterElements(nums)));
        //    Console.ReadLine();
        //}
    }


    //Approach 1
    //TC O(n^2)
    //SC O(n)
    //class Next_Greater_Element_II
    //{
    //    public int[] NextGreaterElements(int[] nums)
    //    {
    //        int n = nums.Length;
    //        int[] result = new int[n];
    //        for (int i = 0; i < n; i++)
    //        {
    //            int count = 0;

    //            for (int j = i + 1; j < n; j++)
    //            {
    //                if (nums[i] < nums[j])
    //                {
    //                    count++;
    //                    result[i] = nums[j];
    //                    break;
    //                }
    //                else
    //                {
    //                    continue;
    //                }
    //            }

    //            if (count == 0)
    //            {
    //                for (int k = 0; k < i; k++)
    //                {
    //                    if (nums[i] < nums[k])
    //                    {
    //                        count = 1;
    //                        result[i] = nums[k];
    //                        break;
    //                    }
    //                    else
    //                    {
    //                        continue;
    //                    }
    //                }
    //            }
    //            if (count == 0)
    //            {
    //                result[i] = -1;
    //            }



    //        }
    //        return result;
    //    }
    //    static void Main(string[] args)
    //    {
    //        Next_Greater_Element_II obj = new Next_Greater_Element_II();

    //        int[] nums = { 1, 2, 3, 4, 3 };
    //        Console.WriteLine(string.Join(",", obj.NextGreaterElements(nums)));
    //        Console.ReadLine();
    //    }
    //}

}