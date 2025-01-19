using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    //TC O(n! *n)
    //SC O(2n)
    class Permutations_II
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            IList<int> ds = new List<int>();
            bool[] freq = new bool[nums.Length];
            Array.Sort(nums);
            Find(nums, freq, ans, ds);
            return ans;
        }
        public void Find(int[] nums,bool[] freq, IList<IList<int>> ans, IList<int> ds){
            if (ds.Count() == nums.Length)
            {
                ans.Add(new List<int>(ds));
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if(freq[i]==true || (i>0 && nums[i]== nums[i-1]&&  freq[i-1]==false)){
                    continue;
                }else{
                    freq[i]=true;
                    ds.Add(nums[i]);
                    Find(nums,freq,ans,ds);
                    ds.RemoveAt(ds.Count()-1);
                    freq[i]=false;
                }

            }
    }
        //static void Main(string[] args)
        //{
        //    Permutations_II obj = new Permutations_II();
        //    int[] nums = {1,2,3};

        //    IList<IList<int>> result = obj.PermuteUnique(nums);
        //    foreach (List<int> a in result)
        //    {
        //        Console.WriteLine(string.Join(",", a));
        //        Console.ReadLine();
        //    }
        //}
    }
}
