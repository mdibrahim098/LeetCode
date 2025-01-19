using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    //TC O(4^n/n^1/2)\
    //SC O(4^n/n^1/2)
    class Generate_Parentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> ans = new List<string>();
            Find(0, 0, "", n, ans);
            return ans;
        }
        public void Find(int open, int close, string current, int n, IList<string> ans)
        {
            if (current.Length == 2 * n)
            {
                ans.Add(current);
                return;
            }
            if (open < n)
            {
                Find(open + 1, close, current + "(", n, ans);
            }
            if (close < open)
            {
                Find(open, close + 1, current + ")", n, ans);
            }
        }
        //static void Main(string[] args)
        //{
        //    Generate_Parentheses obj = new Generate_Parentheses();
        //    int n = 3;
        //    Console.WriteLine(string.Join(",", obj.GenerateParenthesis(n)));
        //    Console.ReadLine();
        //}

    }
}
