using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    internal class ContainsDuplicate
    {
        // Approach 2
        //Time Complexity O(n)
        // Space complexity O(n)
        public bool ContainsDuplicate1(int[] nums)
        {
           HashSet<int> set = new HashSet<int>();
             for(int i = 0;i<nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                }
                set.Add(nums[i]);
            }
            return false;


        }
        /*
        static void Main(string[] args)
        {
            ContainsDuplicate obj = new ContainsDuplicate();

            int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Console.WriteLine(obj.ContainsDuplicate1(nums));


        }
        */
    }


    /*

    // Approach 1
    //Time Complexity O(n^2)
    // Space complexity O(1)
    public bool ContainsDuplicate1(int[] nums)
    {
        for(int i=0; i<nums.Length; i++)
        {
            for(int j=i+1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    return true;
                }
            }
        }
        return false;


    }

    static void Main(string[] args)
    {
        ContainsDuplicate obj = new ContainsDuplicate();

        int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
        Console.WriteLine(obj.ContainsDuplicate1(nums));


    }
}


    */

}
