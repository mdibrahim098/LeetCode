using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    //TC (n)
    //SC(n)
    internal class Longest_Substring_Without_Repeating_Characters
    {

        public int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> dc = new Dictionary<char, int>();
            int left = 0;
            int right;
            int maxLength = 0;
            for(right = 0; right < s.Length; right++)
            {
                char c = s[right];

                if (dc.ContainsKey(c))
                {
                    if(left <= dc[c])
                    {
                        left = dc[c] + 1;
                    }
                }
                maxLength = Math.Max(maxLength, right-left+1);
                dc[c] = right;
            }
            return maxLength;
        }
       /* static void Main(string[] args)
        {
            Longest_Substring_Without_Repeating_Characters obj = new Longest_Substring_Without_Repeating_Characters();

           string s = "pwwkew";
            Console.WriteLine(obj.LengthOfLongestSubstring(s));
        }*/
    }
}
