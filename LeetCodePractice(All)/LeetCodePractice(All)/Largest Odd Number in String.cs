using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice_All_
{

    //TC O(n)
    //SC O(1)
    class Largest_Odd_Number_in_String
    {
        public String largestOddNumber(String num)
        {
            int len = num.Length - 1;
            while (len >= 0)
            {
                int n = num[len] - '0';
                if (n % 2 != 0)
                {
                    return num.Substring(0, len + 1);
                }
                else
                {
                    len--;
                }
            }
            return "";
        }
        //static void Main(string[] args)
        //{
        //    Largest_Odd_Number_in_String obj = new Largest_Odd_Number_in_String();
        //    string num = "4206";
        //    Console.WriteLine(obj.largestOddNumber(num));
        //    Console.ReadLine();
        //}
    }
}
