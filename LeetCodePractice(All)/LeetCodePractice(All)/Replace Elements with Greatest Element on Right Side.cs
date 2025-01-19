using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice_All_
{
    internal class Replace_Elements_with_Greatest_Element_on_Right_Side
    {

        //TC O(n)
        // SC O(n)
        public int[] ReplaceElements(int[] arr)
        {

            if (arr.Length == 1)
            {
                return new int[] { -1 };
            }

            int[] result = new int[arr.Length];
            int max = 0;
            result[arr.Length - 1] = -1;
            for(int i= arr.Length-1;i>0; i--)
            {
                max= Math.Max(max, arr[i]);
                result[i-1] = max;


            }
            return result;
        }
      /*  static void Main(string[] args)
        {
            Replace_Elements_with_Greatest_Element_on_Right_Side obj
                = new Replace_Elements_with_Greatest_Element_on_Right_Side();
            int[] arr = { 17, 18, 5, 4, 6, 1 };
            Console.WriteLine(string.Join(" ",obj.ReplaceElements(arr)));
        }*/

    }
}
