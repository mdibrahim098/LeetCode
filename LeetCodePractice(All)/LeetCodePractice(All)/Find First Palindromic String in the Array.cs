using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice_All_
{

    // TC O(n*m) where n is the length of the array and m is 
    // the length of the each string
    //SC O(1)
    internal class Find_First_Palindromic_String_in_the_Array
    {
        public string FirstPalindrome(string[] words)
        {


            foreach (string word in words)
            {
                bool x = Check(word);
                if (x)
                {
                    return word;
                }
                else
                {
                    continue;
                }

            }
            return "";
        }

       public bool Check(string word)
            {
                int left = 0;
                int right = word.Length - 1;
                while (left < right)
                {
                    if (word[left] != word[right])
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
            Find_First_Palindromic_String_in_the_Array obj = new Find_First_Palindromic_String_in_the_Array();


            string[] words = { "def", "ghi" };
            Console.WriteLine(obj.FirstPalindrome(words));
        }*/
    }
}
