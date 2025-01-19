using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
   internal class Longest_Substring_with_At_Least_K_Repeating_Characters
    {
        public int LongestSubstring(string s, int k)
        {
            int maxLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int[] arr = new int[3]; 

                for (int j = i; j < s.Length; j++)
                {

                    arr[s[j] - 'a']++;
                    if (arr[s[j] - 'a'] >= k)
                    {
                        maxLength = Math.Max(maxLength, j - i + 1);
                    }
                }
            }
            return maxLength;
        }
      /*  static void Main(string[] args)
        {
            Longest_Substring_with_At_Least_K_Repeating_Characters obj = new Longest_Substring_with_At_Least_K_Repeating_Characters();

            string s = "ababbc";
            int k = 2;
            Console.WriteLine(obj.LongestSubstring(s, k));
        }*/
    }
}
