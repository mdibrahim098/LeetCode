using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{


    // Approach 1 
    // TC O(n)
    // SC O(1)
    internal class Isomorphic_Strings
    {
        public bool IsIsomorphic(string s, string t)
        {

            Dictionary<char, char> charMap = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (charMap.ContainsKey(s[i]))
                {
                    if (charMap[s[i]] != (t[i]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (charMap.ContainsValue(t[i]))
                    {
                        return false;
                    }
                    else
                    {
                        charMap.Add(s[i], t[i]);
                    }
                }
            }

            return true;
        }

      /*  static void Main(string[] args)
        {
            Isomorphic_Strings obj = new Isomorphic_Strings();
            string s = "badc";
            string t = "baba";
            Console.WriteLine(obj.IsIsomorphic(s, t));

        }*/


    }



    // Approach 1 
    // TC O(n)
    // SC O(1)
    /* internal class Isomorphic_Strings
     {

         public bool IsIsomorphic(string s, string t)
        {
             bool left = LeftCheck(s, t);    
             bool right = RightCheck(s, t);  
             if(left && right)
             {
                 return true;
             }
             else
             {
                 return false;
             }


        }


         private bool LeftCheck(String s, string t)
         {

             Dictionary<char, char> dict = new Dictionary<char, char>();

             for (int i = 0; i < s.Length; i++)
             {

                 if (dict.ContainsKey(s[i]))
                 {
                     if (dict[s[i]] != t[i])
                     {
                         return false;
                     }
                 }
                 dict[s[i]] = t[i];
             }
             return true;
         }

         private bool RightCheck(String s, string t)
         {

             Dictionary<char, char> dict = new Dictionary<char, char>();

             for (int i = 0; i < t.Length; i++)
             {

                 if (dict.ContainsKey(t[i]))
                 {
                     if (dict[t[i]] != s[i])
                     {
                         return false;
                     }
                 }
                 dict[t[i]] = s[i];
             }
             return true;
         }

         static void Main(string[] args)
         {
             Isomorphic_Strings obj = new Isomorphic_Strings();
             string s = "badc";
             string t = "baba";
             Console.WriteLine(obj.IsIsomorphic(s,t));

         }
     }*/

}
