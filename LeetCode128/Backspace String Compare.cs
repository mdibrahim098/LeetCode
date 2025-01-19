using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    // Approach 2
    // TC O(n)
    // SC O(n)
    internal class Backspace_String_Compare
    {
        public bool BackspaceCompare(string s, string t)
        {
            return actualString(s).Equals(actualString(t));
           
        }
        private string actualString(string input)
        {
            String s = "";
            int hashCount = 0;
            for(int i= input.Length-1; i>=0; i--)
            {
                if (input[i] == '#')
                {
                    hashCount++;
                    continue;
                }
                if(hashCount > 0)
                {
                    hashCount--;
                }
                else
                {
                    s = input[i] + s;
                }
            }
            return s;
        }

       /* static void Main(string[] args)
        {

            Backspace_String_Compare obj = new Backspace_String_Compare();


            string s = "abcd", t = "bbcd";
            Console.WriteLine(obj.BackspaceCompare(s, t));

        }*/
    }

    // Approach 1
    // TC O(n)
    // SC O(n)
    /*  internal class Backspace_String_Compare
      {
          public bool BackspaceCompare(string s, string t)
          {
              char[] c1 = s.ToCharArray();
              char[] c2 = t.ToCharArray();
              Stack<char> s1 = new Stack<char>();

              Stack<char> s2 = new Stack<char> ();

              for (int i = 0; i < s.Length; i++)
              {

                  if (c1[i] == '#' && s1.Count!=0)
                  {
                      s1.Pop();
                  }
                  else if(c1[i] != '#')
                  {
                      s1.Push(c1[i]);

                  }


              }
              for (int i = 0; i < t.Length; i++)
              {

                  if (c2[i] == '#' && s2.Count != 0)
                  {
                      s2.Pop();
                  }
                  else if(c2[i] != '#')
                  {
                      s2.Push(c2[i]);

                  }


              }
              int l = s1.Count;
              if (s1.Count == 0 && s2.Count == 0)
              {
                  return true;
              }
              if (s1.Count != s2.Count)
              {
                  return false;
              }
             else
              {
                  for (int i = 0; i <l; i++)
                  {

                      if (s1.Pop() != s2.Pop())
                      {

                          return false;
                      }
                      else
                      {

                          continue;
                      }
                  }
              }



              return true;
          }

          static void Main(string[] args)
          {

              Backspace_String_Compare obj = new Backspace_String_Compare();


              string s = "abcd", t = "bbcd";
              Console.WriteLine(obj.BackspaceCompare(s,t));

          }
      }*/
}
