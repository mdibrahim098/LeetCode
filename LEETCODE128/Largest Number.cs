using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    //TC O(nlogn)
    //SC O(n)
    class Largest_Number
    {
        public string LargestNumber(int[] nums)
        {
            string[] s = new string[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                s[i] = nums[i].ToString();
            }
            Array.Sort(s,(a,b)=>string.Compare(b+a,a+b));
            if (s[0] == "0")
            {
                return "0";
            }
            return string.Join("", s);

        }
        //static void Main(string[] args)
        //{
        //    Largest_Number obj = new Largest_Number();
        //    int [] nums = {3,30,34,5,9};
        //    Console.WriteLine(obj.LargestNumber(nums));
        //    Console.ReadLine();
        //}
    }
}
