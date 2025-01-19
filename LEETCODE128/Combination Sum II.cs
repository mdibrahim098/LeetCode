using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    //TC O(2^n *k)
    //SC O(n*k)
    class Combination_Sum_II
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            IList<int> ds = new List<int>();
            Array.Sort(candidates);
            Find(0, candidates, target, ans,ds);
            return ans;
        }
        public void Find(int index, int[] candidates, int target, IList<IList<int>> ans, IList<int> ds)
        {
            if (target == 0)
            {
                ans.Add(new List<int>(ds));
                return;
            }
            for (int i = index; i < candidates.Length; i++)
            {
                if (i > index && candidates[i] == candidates[i - 1])
                {
                    continue;
                }
                if (candidates[i] > target)
                {
                    break;
                }
                ds.Add(candidates[i]);
                Find(i + 1, candidates, target - candidates[i], ans, ds);
                ds.RemoveAt(ds.Count() - 1);
            }

        }
        //static void Main(string[] args)
        //{
        //    Combination_Sum_II obj = new Combination_Sum_II();
        //   int[]  candidates = {10,1,2,7,6,1,5};
        //    int target = 8;
        //    IList<IList<int>> result = obj.CombinationSum2(candidates, target);
        //    foreach (List<int> a in result)
        //    {
        //        Console.WriteLine(string.Join(",", a));
        //        Console.ReadLine();
        //    }
        //}
    }
}
