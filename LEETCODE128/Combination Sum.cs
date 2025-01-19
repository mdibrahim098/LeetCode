using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    //TC(2^n *k)
    //SC (n*K)
    class Combination_Sum
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            IList<int> ds = new List<int>();
            Find(0, candidates, target, ans, ds);
            return ans;
           
        }
        private void Find(int index, int[] candidates, int target, IList<IList<int>> ans, IList<int> ds)
        {
            if (index == candidates.Length)
            {
                if (target == 0)
                {
                    ans.Add(new List<int>(ds));
                }
                return;
            }
            if (candidates[index] <= target)
            {
                ds.Add(candidates[index]);
                Find(index, candidates, target - candidates[index], ans, ds);
                ds.RemoveAt(ds.Count-1);
            }
            Find(index, candidates, target - candidates[index], ans, ds);
        }
        //static void Main(string[] args)
        //{
        //    Combination_Sum obj = new Combination_Sum();
        //    int[] candidates = { 2, 3, 6, 7 };
        //    int target = 7;
        //    IList<IList<int>> result = obj.CombinationSum(candidates, target);

        //    foreach (var combination in result)
        //    {
        //        Console.WriteLine(string.Join(", ", combination));
        //    }
        //}
    }
}
