using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    //Approach 2
    // Time Compexity O(n)
    // Space Compexity O(n)
    // where n is the total number of elements
  
       
  
         
        internal class MajorityElement
       {
           public int MajorityElement1(int[] nums)
           {

               Dictionary<int, int> dc = new Dictionary<int, int>();
               for (int i = 0; i < nums.Length; i++)
               {
                   if (dc.ContainsKey(nums[i]))
                   {
                       dc[nums[i]]++;
                       if (dc[nums[i]] > nums.Length / 2)
                       {
                           return nums[i];
                       }
                   }
                   else
                   {
                       dc[nums[i]] = 1;
                   }


               }
               return nums[0];
           }

        /*
           static void Main(string[] args)
           {
               MajorityElement obj = new MajorityElement();

               int[] nums = { 2, 2, 1, 1, 1, 2, 2 ,1,1,1};
               Console.WriteLine(obj.MajorityElement1(nums));
           }

        */

       }

       /*
       //Approach 1
      // TimeComplexity O(nlogn);
      // SpaceComplexity O(1;)
       // where n is the total number of elements
       internal class MajorityElement
       {


           public int MajorityElement1(int[] nums)
           { 

               Array.Sort(nums);
               return nums[nums.Length / 2];

           }
           static void Main(string[] args)
           {
               MajorityElement obj = new MajorityElement();

               int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
               Console.WriteLine(obj.MajorityElement1(nums));
           }
       }

       */

}
