using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LEETCODE128
{

    //TC O(n)
    //SC O(1)
    internal class Valid_Palindrome
    {
        public bool IsPalindrome(string s)
        {
            s = Regex.Replace(s,"[^A-Za-z0-9]","").ToLower();
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (s[left]!= s[right]){
                    return false;
                }
                else
                {
                    left++;
                    right--;
                }
            }
            return true;
        }
       /* static void Main(string[] args)
        {
            Valid_Palindrome obj = new Valid_Palindrome();
            string s = "A man, a plan, a canal: Panama";
            Console.WriteLine(obj.IsPalindrome(s));
        }*/
    }
}
