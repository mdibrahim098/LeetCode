using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice_All_
{

    // TC O(n) where n is the length of the string
    //SC O(1)
    internal class Valid_Palindrome_II
    {
        public bool ValidPalindrome(string s)
        {
            if (s.Length == 2)
            {
                return true;
            }
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {

                if (s[left] != s[right])
                {
                    // Try skipping the character on the left
                    bool x = IsPalindrome(s, left + 1, right);
                    // Try skipping the character on the right
                    bool y = IsPalindrome(s, left, right - 1);

                    if (x)
                    {
                        return true;
                    }
                   else if  (y)
                    {
                        return true;
                    }
                    else
                    {
                        // If neither case is a palindrome, return false
                        return false;
                    }

                   
                }
                else{
                    left++;
                    right--;
                }
            }


            return false;

        }

        public static bool IsPalindrome(string s, int left, int right)
        {

            
      
            while (left < right)
            {
                if (s[left] != s[right])
                {
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
            Valid_Palindrome_II obj = new Valid_Palindrome_II();
            string s = "abca";  // ans : true
            Console.WriteLine(obj.ValidPalindrome(s));


        }*/

    }
}
