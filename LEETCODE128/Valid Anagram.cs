using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{



    // Approach 2 
    // TC O(n)
    // SC O(1)
    internal class Valid_Anagram
    {
        public bool IsAnagram(string s, string t)
        {
            int a = s.Length;
            int b = t.Length;
            if (a != b)
            {
                return false;
            }
            int[] c = new int[26];
            int[] d = new int[26];
            for (int i = 0; i < a; i++)
            {
                c[s[i] - 'a']++;
            }
            for (int i = 0; i < a; i++)
            {
                d[t[i] - 'a']++;
            }
            if (c.SequenceEqual(d))
            {
                return true;
            }
            return false;
        }

        /*
        static void Main(string[] args)
        {
            Valid_Anagram obj = new Valid_Anagram();

            string s = "anagram";
            string t = "nagaram";
            Console.WriteLine(obj.IsAnagram(s, t));


        }

        */
    }

    /*

    //TC O(nlogn)
   // OC O(n)
    internal class Valid_Anagram
    {
        public bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length) return false;

            char[] c1  = s.ToCharArray();
            char[] c2 = t.ToCharArray();    
             Array.Sort(c1);
              Array.Sort(c2);
            for(int i = 0; i < c1.Length; i++)
            {
                if (c1[i] != c2[i]) return false;
               
                    
                
            }
            return true;

        }

        static void Main(string[] args)
        {
            Valid_Anagram obj = new Valid_Anagram();

            string s = "anagram";
            string t = "nagaram";
            Console.WriteLine(obj.IsAnagram(s,t));


        }
    }

    */
}
