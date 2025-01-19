using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    //Approach 2
    // TC O(n)
    //SC O(1)
    internal class Two_Sum_II___Input_Array_Is_Sorted
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while (left <= right)
            {
                if (numbers[left] + numbers[right] == target)
                {
                    return new int[] { left + 1, right + 1 };
                }else if (numbers[left] + numbers[right] > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }

            }
            return null;
        }

      /*  static void Main(string[] args)
        {
            Two_Sum_II___Input_Array_Is_Sorted
            obj = new Two_Sum_II___Input_Array_Is_Sorted();
            int[] numbers = { 2, 7, 11, 15 };
            int target = 9;
            Console.WriteLine(string.Join(",", obj.TwoSum(numbers, target)));

        }*/
    }

    //Approach 1
    // TC O(n)
    //SC O(n)
    /*internal class Two_Sum_II___Input_Array_Is_Sorted
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            Dictionary<int, int> dc = new Dictionary<int, int>();
            for(int i=0; i< numbers.Length; i++)
            {
                int num = target - numbers[i];
                if (dc.ContainsKey(num))
                {
                    return new int[] { dc[num], i + 1 };
                }
                dc.Add(numbers[i], i + 1);
            }
            return new int[] { };
        }

        static void Main(string[] args)
        {
            Two_Sum_II___Input_Array_Is_Sorted
            obj = new Two_Sum_II___Input_Array_Is_Sorted();
            int[] numbers = { 2, 7, 11, 15 };
            int target = 9;
            Console.WriteLine(string.Join(",",obj.TwoSum(numbers, target)));

        }
    }*/
}
