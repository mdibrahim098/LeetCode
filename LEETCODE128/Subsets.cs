using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    //TC O(2^n)
    //SC O(n)
    class Subset
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            IList<int> ds = new List<int>();
            Find(0, nums, ds, ans);
            return ans;
        }
        public void Find(int index, int[] nums, IList<int> ds, IList<IList<int>> ans)
        {
            if (index == nums.Length)
            {
                ans.Add(new List<int>(ds));
                return;
            }
            ds.Add(nums[index]);
            Find(index + 1, nums, ds, ans);
            ds.RemoveAt(ds.Count() - 1);
            Find(index + 1, nums, ds, ans);
        }
        
        //void Main(string[] args)
        //{
        //    Subset obj = new Subset();
        //    int[] nums = { 1, 2, 3 };
        //    IList<IList<int>> result = obj.Subsets(nums);

        //    foreach (var a in result)
        //    {
        //        Console.WriteLine(string.Join(", ", a));
        //        Console.ReadLine();
        //    }
        //}
    }





    ////public class Solution
    ////{
    ////    public IList<IList<int>> Subsets(int[] nums)
    ////    {
    ////        IList<IList<int>> ans = new List<IList<int>>();
    ////        IList<int> ds = new List<int>();
    ////        Find(0, nums, ds, ans);
    ////        return ans;
    ////    }
    ////    public void Find(int index, int[] nums, IList<int> ds, IList<IList<int>> ans)
    ////    {

    ////        ans.Add(new List<int>(ds));

    ////        for (int i = index; i < nums.Length; i++)
    ////        {
    ////            ds.Add(nums[i]);
    ////            Find(i + 1, nums, ds, ans);
    ////            ds.RemoveAt(ds.Count() - 1);
    ////        }

    ////       
    ////    }
    ////}

}
