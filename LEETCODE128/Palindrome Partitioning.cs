using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    class Palindrome_Partitioning
    {
        public IList<IList<string>> Partition(string s)
        {
            IList<IList<string>> ans = new List<IList<string>>();
            IList<string> ds = new List<string>();
            Find(0, s, ans, ds);
            return ans;
        }
       public void Find(int index, string s, IList<IList<string>> ans, IList<string> ds)
        {
            if (index == s.Length)
            {
                ans.Add(new List<string>(ds));
                return;
            }
            for (int i = index; i < s.Length; i++)
            {
                if (Palindrome(s, index, i))
                {
                    ds.Add(s.Substring(index,i+1));
                    Find(i+1,s,ans,ds);
                    ds.RemoveAt(ds.Count() - 1);

                }
            }
           

        }
        public bool Palindrome(string s, int index, int i){
            while (index <= i)
            {
                if (s[index++] != s[i--])
                {
                    return false;
                }
            }
            return true;
            }
        //static void Main(string[] args)
        //{
        //    Palindrome_Partitioning obj = new Palindrome_Partitioning();
        //    string s = "aab";

        //    IList<IList<string>> result = obj.Partition(s);

        //    foreach (var Partition in result)
        //    {
        //        Console.WriteLine(string.Join(", ", Partition));
        //        Console.ReadLine();
        //    }
        //    Console.ReadLine();
        //}
    }
}
