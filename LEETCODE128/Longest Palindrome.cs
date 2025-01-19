using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    //TC O(n)
    //SC O(1)
    class Longest_Palindrome
    {
        public int LongestPalindrome(string s)
        {
            int[] count = new int[128];
            for (int i = 0; i < s.Length;i++ )
            {
                count[s[i]]++;
            }
            int result = 0;
            for (int i = 0; i < count.Length; i++)
            {
                int val = count[i];
                result += (val / 2) * 2;
                if (result % 2 == 0 && val % 2 == 1)
                {
                    result++;
                }
            }
            return result;
        }
        //static void Main(string[] args)
        //{
        //    Longest_Palindrome obj = new Longest_Palindrome();
        //    string s = "abccccdd";
        //    Console.WriteLine(obj.LongestPalindrome(s));
        //    Console.ReadLine();

        //}
    }
}
