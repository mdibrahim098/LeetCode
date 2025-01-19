using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

   // Time Complexity: O(k * C(n, k))
//Space Complexity: O(k * C(n, k))
    class Combinations
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            IList<int> ds = new List<int>();
            Find(1, n, k, ans, ds);
            return ans;
        }
        public void Find(int index, int n, int k, IList<IList<int>> ans, IList<int> ds)
        {
            if (ds.Count() == k)
            {
                ans.Add(new List<int>(ds));
                return;
            }
            for (int i = index; i <= n; i++)
            {
                ds.Add(i);
                Find(i + 1, n, k, ans, ds);
                ds.RemoveAt(ds.Count() - 1);
            }
        }
        //static void Main(string[] args)
        //{
        //    Combinations obj = new Combinations();
        //    int n = 4, k = 2;
        //    IList<IList<int>> result = obj.Combine(n,k);

        //    foreach (var a in result)
        //    {
        //        Console.WriteLine(string.Join(", ", a));
        //        Console.ReadLine();
        //    }
        //}
    }
}
