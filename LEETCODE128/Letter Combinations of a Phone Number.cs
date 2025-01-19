using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    //Time Complexity: O(n*4^n)
    //where n is the length of the string
    //Space Complexity: O(n*4^n)
    class Letter_Combinations_of_a_Phone_Number
    {

        public Dictionary<char, string> dc;
        public IList<string> LetterCombinations(string digits)
        {
            dc = new Dictionary<char, string>();
            dc.Add('2', "abc");
            dc.Add('3', "def");
            dc.Add('4', "ghi");
            dc.Add('5', "jkl");
            dc.Add('6', "mno");
            dc.Add('7', "pqrs");
            dc.Add('8', "tuv");
            dc.Add('9', "wxyz");
            if (digits.Length == 0)
            {
                return new List<string>();
            }
            List<string> ans = new List<string>();
            string current = "";
            backtracking(digits, current, ans, 0);
            return ans;
        }

        public void backtracking(string digits, string current, List<string> ans, int index)
        {
            if (current.Length == digits.Length)
            {
                ans.Add(current);
                return;
            }
            else if (index >= digits.Length)
            {
                return;
            }
            else
            {
                string digit = dc[digits[index]];
               foreach(char c in digit.ToCharArray()){
                   backtracking(digits,current+c,ans,index+1);
               }
            }
        }

        //static void Main(string[] args)
        //{
        //    Letter_Combinations_of_a_Phone_Number obj = new Letter_Combinations_of_a_Phone_Number();
        //    string digits = "23";
        //    Console.WriteLine(string.Join(",",obj.LetterCombinations(digits)));
        //    Console.ReadLine();
        //}
        
    }
}
