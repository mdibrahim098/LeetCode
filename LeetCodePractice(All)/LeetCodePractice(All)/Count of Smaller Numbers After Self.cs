using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice_All_
{


    //Approach 1 
    // TC O(N^2)
    // SC O(1)
    internal class Count
    {

        public IList<int> CountSmaller(int[] nums)
        {
            IList<int> list = new List<int>();
            if (nums.Length == 1)
            {
                return new List<int>() { 0 };
            }

            for (int i = 0; i < nums.Length; i++)
            {

                int count = 0;
                for (int j = i; j < nums.Length; j++)
                {

                    if (nums[i] > nums[j])
                    {
                        count++;
                    }

                }
                if (count == 0)
                {
                    list.Add(0);
                }
                else
                {
                    list.Add(count);
                }
            }
            return list;
        }

       /* static void Main(string[] args)
        {
             Count obj = new Count();
            int[] nums = { 5, 2, 6, 1 };
            Console.WriteLine(string.Join(" ", obj.CountSmaller(nums)));


        }*/
    }
}
