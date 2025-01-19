using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    //TC O(n) 
    //SC O(n)
    class Remove_Duplicate_Letters
    {
        public string RemoveDuplicateLetters(string s)
        {
            int[] lastIndex = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                lastIndex[s[i] - 'a'] = i;
            }
            bool[] seen = new bool[26];
            Stack<char> st = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                int curr = s[i] - 'a';
                if (seen[curr])
                {
                    continue;
                }
                while (st.Count > 0 && st.Peek() > s[i] && i < lastIndex[st.Peek() - 'a'])
                {
                    seen[st.Peek() - 'a'] = false;
                    st.Pop();
                }
                st.Push(s[i]);
                seen[curr] = true;
            }
            string result = "";
            while (st.Count > 0)
            {
                result = st.Peek() + result;
                st.Pop();
            }
            return result;
        }
        //static void Main(string[] args)
        //{
        //    Remove_Duplicate_Letters obj = new Remove_Duplicate_Letters();
        //    string s = "cbacdcbc";
        //    Console.WriteLine(obj.RemoveDuplicateLetters(s));
        //}
    }
}
