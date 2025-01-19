using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    //TC O(n! *n)
    //SC O(2n)
    class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            IList<int> ds = new List<int>();
            bool[] freq = new bool[nums.Length];
            Find(nums, ds, ans, freq);
            return ans;
        }
        public void Find(int[] nums, IList<int> ds, IList<IList<int>> ans, bool[] freq)
        {
            if (ds.Count == nums.Length)
            {
                ans.Add(new List<int>(ds));
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (freq[i] == false)
                {
                    freq[i] = true;
                    ds.Add(nums[i]);
                    Find(nums, ds, ans, freq);
                    ds.RemoveAt(ds.Count() - 1);
                    freq[i] = false;
                }
            }
        }
        //static void Main(string[] args)
        //{
        //    Permutations obj = new Permutations();
        //    int[] nums= { 1, 2, 3 };
            
        //    IList<IList<int>> result = obj.Permute(nums);

        //    foreach (var Permute in result)
        //    {
        //        Console.WriteLine(string.Join(", ", Permute));
        //        Console.ReadLine();
        //    }
        //    Console.ReadLine();
        //}
    }
}
