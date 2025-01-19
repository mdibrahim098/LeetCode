using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    //TC O(2^n *k)
    //SC O(n*k)
    class Combination_Sum_III
    {
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            IList<int> ds = new List<int>();
            Find(1, 0, k, n, ans, ds);
            return ans;
        }

        public void Find(int index, int sum, int k, int n, IList<IList<int>> ans, IList<int> ds)
        {
            if (sum == n && k == 0)
            {
                ans.Add(new List<int>(ds));
                return;
            }

            for (int i = index; i <= 9; i++)
            {
                if (i > n)
                {
                    break;
                }
                ds.Add(i);
                Find(i + 1, sum + i, k - 1, n, ans, ds);
                ds.RemoveAt(ds.Count() - 1);
            }
        }
        //static void Main(string[] args)
        //{
        //    Combination_Sum_III obj = new Combination_Sum_III();
        //    int k = 3;
        //    int n = 7;
        //    IList<IList<int>> result = obj.CombinationSum3(k,n);

        //    foreach (var combination in result)
        //    {
        //        Console.WriteLine(string.Join(", ", combination));
        //    }
        //}
    }
}
