using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode128
{

    //TC(n)
    //SC(1)
    class Substrings_of_Size_Three_with_Distinct_Characters
    {
        public int CountGoodSubstrings(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length - 2; i++)
            {
                HashSet<char> set = new HashSet<char>();
                for (int j = i; j < i + 3; j++)
                {
                    if (set.Contains(s[j]))
                    {
                        break;
                    }
                    set.Add(s[j]);

                }
                if (set.Count == 3)
                {
                    count++;
                }
            }
            return count;
        }
        //static void Main(string[] args)
        //{
        //    Substrings_of_Size_Three_with_Distinct_Characters obj = new Substrings_of_Size_Three_with_Distinct_Characters();
        //    string s = "xyzzaz";
        //    
        //    Console.WriteLine(obj.CharacterReplacement(s));
        //    Console.ReadLine();
        //}
    }
}
