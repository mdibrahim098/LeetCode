using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice_All_
{

    // TC O(nlogn)
    // SC O(n)
  /*  internal class Wiggle_Sort_II
    {

        public void WiggleSort(int[] nums)
        {
            if(nums.Length < 2)
            {
                return;
            }

            Array.Sort(nums);
            int[] result = new int[nums.Length];
            int j = 1;
            for(int i=nums.Length-1; i>=0; i--)
            {
                result[j]= nums[i];
                j += 2;
                if (j >= nums.Length)
                {
                    j = 0;
                }
            }

            for(int i=0; i< nums.Length; i++)
            {
                nums[i] = result[i];
            }
            Console.WriteLine(string.Join(",",nums));
        }

        static void Main(string[] args)
        {
            Wiggle_Sort_II obj = new Wiggle_Sort_II();

           int[] nums = { 1, 3, 2, 2, 3, 1 };
            obj.WiggleSort(nums);   
        }
    }*/
}
