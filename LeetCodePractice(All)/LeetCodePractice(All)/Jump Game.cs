using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LeetCodePractice_All_
{

    //TC O(n)
    //SC O(1)
    internal class Jump_Game
    {

        public bool CanJump(int[] nums)
        {
            int finalPosition= nums.Length-1;
            for(int i = finalPosition-2;i>=0; i--)
            {
                if ((i + nums[i])>= finalPosition)
                {
                    finalPosition = i;
                }
              
            }
            return finalPosition==0;

        }
       /* static void Main(string[] args)
        {

            Jump_Game obj = new Jump_Game();
            int[] nums = {2, 3, 1, 1, 4};
            Console.WriteLine(obj.CanJump(nums));


        }*/



    }
}
