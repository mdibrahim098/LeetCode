using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    // TC O(nlogN)
    // SC O(n)
    class _567
    {

        public bool CheckInclusion(string s1, string s2)
        {
            char[] str1 = s1.ToCharArray();
            Array.Sort(str1);
            int k = str1.Length;
            for (int i = 0; i <= s2.Length - k; i++)
            {
                string str = s2.Substring(i, k);
                char[] str2 = str.ToCharArray();
                Array.Sort(str2);
                if (str2.SequenceEqual(str1))
                {
                    return true;
                }
            }
            return false;
        }
        //static void Main(string[] args)
        //{
        //    _567 obj = new _567();
        //    string s1 = "ab";
        //        string s2 = "eidbaooo";
        //        Console.WriteLine(obj.CheckInclusion
        //    (s1,s2));
        //        Console.ReadLine();
        //}
    }
}
