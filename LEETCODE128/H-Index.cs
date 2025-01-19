using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    // TC O(nlogn)
    // SC O(n)
    internal class H_Index
    {
        public int HIndex(int[] citations)
        {
          Array.Sort(citations);
            Array.Reverse(citations);
         

            
           for(int i=0; i<citations.Length; i++)
            {
                if (citations[i] < i+1 )
                {
                    return i;
                }
               
            }

            return citations.Length;
        
        }
       /* static void Main(string[] args)
        {
            H_Index obj = new H_Index();
            int[] citations = { 3, 0, 6, 1, 5 };
            Console.WriteLine(obj.HIndex(citations));


        }*/

    }
}
