using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    // TC O(logn)
    // SC(1)
   /* internal class First_Bad_Version
    {
        public int FirstBadVersion(int n)
        {
            Solution obj = new Solution
            int left = 1;
            int right = n;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (obj.IsBadVersion(mid) == true)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return right;
        }


    }*/
}
