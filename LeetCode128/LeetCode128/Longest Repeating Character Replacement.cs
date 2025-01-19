using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode128
{


    //Approach 2
    //TC O(n^2)
    //SC O(1)
    public class Longest_Repeating_Character_Replacement
    {
        public int CharacterReplacement(string s, int k)
        {

            int maxLength = 0;
            int maxFreq = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int[] array = new int[26];
                for (int j = i; j < s.Length; j++)
                {
                    array[s[j] - 'A']++;
                    maxFreq = Math.Max(maxFreq, array[s[j] - 'A']);
                    if (j - i + 1 - maxFreq > k)
                    {
                        break;

                    }
                    maxLength = Math.Max(maxLength, j - i + 1);
                }
            }
            return maxLength;
        }
        //static void Main(string[] args)
        //{
        //    Longest_Repeating_Character_Replacement obj = new Longest_Repeating_Character_Replacement();
        //    string s = "ABAB";
        //    int k = 2;
        //    Console.WriteLine(obj.CharacterReplacement(s, k));
        //    Console.ReadLine();
        //}
    }

    //Approach 1
    //TC O(n)
    //SC O(1)
  
        //public class Longest_Repeating_Character_Replacement
        //{
        //    public int CharacterReplacement(string s, int k)
        //    {
        //        int left = 0;
        //        int right;
        //        int maxFreq = 0;
        //        int maxLength = 0;
        //        int[] array = new int[26];
        //        for (right = 0; right < s.Length; right++)
        //        {
        //            array[s[right] - 'A']++;
        //            maxFreq = Math.Max(maxFreq, array[s[right] - 'A']);
        //            if (right - left + 1 - maxFreq > k)
        //            {
        //                array[s[left] - 'A']--;
        //                left++;
        //            }
        //            maxLength = Math.Max(maxLength, right - left + 1);
        //        }
        //        return maxLength;
        //    }
        //    static void Main(string[] args)
        //    {
        //        Longest_Repeating_Character_Replacement obj = new Longest_Repeating_Character_Replacement();
        //        string s = "ABAB";
        //        int k = 2;
        //        Console.WriteLine(obj.CharacterReplacement(s, k));
        //        Console.ReadLine();
        //    }
        //}

    
}
