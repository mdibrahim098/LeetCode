using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{


    //TC O(2^n)
    //SC O(n)
    class Subsets_II
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            IList<int> ds = new List<int>();
            Array.Sort(nums);
            Find(0, nums, ds, ans);
            return ans;
        }
        public void Find(int index, int[] nums, IList<int> ds, IList<IList<int>> ans)
        {
            ans.Add(new List<int>(ds));
            for (int i = index; i < nums.Length; i++)
            {
                if (i > index && nums[i] == nums[i - 1])
                {
                    continue;
                }

                ds.Add(nums[i]);
                Find(i + 1, nums, ds, ans);
                ds.RemoveAt(ds.Count() - 1); 
            }
        }
    //    void Main(string[] args)
    //    {
    //        Subsets_II obj = new Subsets_II();
    //        int[] nums = { 1, 2, 2 };
    //        IList<IList<int>> result = obj.SubsetsWithDup(nums);

    //        foreach (var a in result)
    //        {
    //            Console.WriteLine(string.Join(", ", a));
    //            Console.ReadLine();
    //        }
    //    }
    }
}
