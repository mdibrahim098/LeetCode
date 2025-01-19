using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice_All_
{

    //TC O(n)
    //SC O(1)
    class Grumpy_Bookstore_Owner
    {
        public int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
        {
            int n = customers.Length;
            int left = 0;
            int right = 0;
            int maxNum = 0;
            int sum = 0;
            int maxgrumpydelete = 0;

            while (right < n)
            {

                if (grumpy[right] == 1)
                {
                    sum += customers[right];
                }

                if ((right - left + 1) == minutes)
                {

                    maxgrumpydelete = Math.Max(maxgrumpydelete, sum);

                    if (grumpy[left] == 1)
                    {
                        sum -= customers[left];
                    }

                    left++;

                }

                right++;

            }



            for (left = 0; left < n; left++)
            {

                if (grumpy[left] == 0)
                {
                    maxgrumpydelete += (customers[left]);
                }

            }

            return maxgrumpydelete;
        }
        //static void Main(string[] args)
        //{
        //    Grumpy_Bookstore_Owner obj = new Grumpy_Bookstore_Owner();
        //   int[] customers = {1,0,1,2,1,1,7,5};
        //    int[] grumpy = {0,1,0,1,0,1,0,1};
        //    int minutes = 3;
        //    Console.WriteLine(obj.MaxSatisfied(customers
        //        ,grumpy,minutes));
        //}
    }
}
