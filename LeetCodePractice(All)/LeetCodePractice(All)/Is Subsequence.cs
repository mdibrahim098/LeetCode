using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice_All_
{

    //TC O(n)
    //SC O(1)
    internal class Is_Subsequence
    {
        public bool IsSubsequence(string s, string t)
        {
            int i = 0;
            for (int j=0; j < t.Length; j++)
            {

                if (i<s.Length && s[i] == t[j])
                {
                    i++;
                }
            }

            return i == s.Length;
        }

      /*  static void Main(string[] args)
        {
            Is_Subsequence obj = new Is_Subsequence();

            string s = "axc";
            string t = "ahbgdc";

            Console.WriteLine(obj.IsSubsequence(s,t));
        }*/

    }
}
