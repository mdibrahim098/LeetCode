using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode128
{
    class Find_All_Anagrams_in_a_String
    {
        //TC (n.klogk)
        //SC (n+k)
        public IList<int> FindAnagrams(string s, string p)
        {

            IList<int> result = new List<int>();
            char[] pc = p.ToCharArray();
            Array.Sort(pc);

            int k = pc.Length;
            for (int i = 0; i <= s.Length - k; i++)
            {
                string str = s.Substring(i, k);
                char[] sort = str.ToCharArray();
                Array.Sort(sort);
                if (pc.SequenceEqual(sort))
                {
                    result.Add(i);
                }
            }
            return result;
        }
        //static void Main(string[] args)
        //{
        //    Find_All_Anagrams_in_a_String obj = new Find_All_Anagrams_in_a_String();

        //  string  s = "cbaebabacd";
        //  string p = "abc";
        //  Console.WriteLine(string.Join(",",obj.FindAnagrams(s,p)));
        //  Console.ReadLine();

        //}
    }
  
}
