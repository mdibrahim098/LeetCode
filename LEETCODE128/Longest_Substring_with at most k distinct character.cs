using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{


    //Approach 2
    //TC O(n)
    //SC O(k)
     internal class Longest_Substring_with_at_most_k_distinct_character
      {
          public int Longest_Substring_with_(string s, int k)
          {
            int left = 0;
            int right=0;
            int maxLength = 0;
            Dictionary<char,int> map = new Dictionary<char,int>();
            while (right < s.Length)
            {
                if (map.ContainsKey(s[right]))
                {
                    map[s[right]]++;
                }
                else
                {
                    map[s[right]] = 1;
                }
                if (map.Count > k)
                {
                    map[s[left]]--;
                    left++;
                }
                else
                {
                    maxLength = Math.Max(maxLength,right - left + 1);
                }
                right++;
            }
            return maxLength;
          }
         /* static void Main(string[] args)
          {
              Longest_Substring_with_at_most_k_distinct_character obj = new Longest_Substring_with_at_most_k_distinct_character();

              string s = "aaabbccd";
              int k = 2;
              Console.WriteLine(obj.Longest_Substring_with_(s,k));

          }*/
      }

    //Approach 1
    //TC O(n^2)
    //SC O(k)
    /*  internal class Longest_Substring_with_at_most_k_distinct_character
      {
          public int Longest_Substring_with_(string s, int k)
          {

              int maxLength = 0;

              for (int i=0; i<s.Length; i++)
              {
                  Dictionary<char, int> dc = new Dictionary<char, int>();
                  for (int j=i; j<s.Length; j++)
                  {
                      if (dc.ContainsKey(s[j]))
                      {
                          dc[s[j]]++;
                      }
                      else
                      {
                          dc[s[j]]= 1;
                      }

                      if (dc.Count > k)
                      {
                          break;
                      }
                      else
                      {
                          maxLength= Math.Max(maxLength, j-i+1);
                      }


                  }
              }
              return maxLength;
          }
          static void Main(string[] args)
          {
              Longest_Substring_with_at_most_k_distinct_character obj = new Longest_Substring_with_at_most_k_distinct_character();

              string s = "aaabbccd";
              int k = 2;
              Console.WriteLine(obj.Longest_Substring_with_(s,k));

          }
      }*/
}
