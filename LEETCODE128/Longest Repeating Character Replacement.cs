using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    //TC O(n)
    //SC O(1)
    internal class Longest_Repeating_Character_Replacement
    {
        
            public int CharacterReplacement(string s, int k)
            {
                int left = 0;
                int[] array = new int[26];
                int maxLength = 0;
                int maxFreq = 0;
                for (int right = 0; right < s.Length; right++)
                {

                    array[s[right] - 'A']++;
                    maxFreq = Math.Max(maxFreq, array[s[right] - 'A']);
                    if (right - left + 1 - maxFreq > k)
                    {
                        array[s[left] - 'A']--;
                        left++;

                    }

                    maxLength = Math.Max(maxLength, right - left + 1);
                }
                return maxLength;
            }

       /* static void Main(string[] args)
        {
            Longest_Repeating_Character_Replacement obj = new Longest_Repeating_Character_Replacement();

           string s = "AABABBA"; int k = 1;
            Console.WriteLine(obj.CharacterReplacement(s,k));

        }*/
    }
}
