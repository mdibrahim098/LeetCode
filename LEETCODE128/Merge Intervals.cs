using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
 //TC O(nlogn)
    //SC O(n)
     public class Merge_Intervals
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Length <= 1)
        {
            return intervals;
        }

        // Sort intervals by the start value
        intervals = intervals.OrderBy(interval => interval[0]).ToArray();

        List<int[]> result = new List<int[]>();
        int[] currentInterval = intervals[0];
        result.Add(currentInterval);

        foreach (int[] interval in intervals)
        {
            if (interval[0] <= currentInterval[1])
            {
                // Overlapping intervals, merge them
                currentInterval[1] = Math.Max(interval[1], currentInterval[1]);
            }
            else
            {
                // Non-overlapping interval, add to the result list
                currentInterval = interval;
                result.Add(currentInterval);
            }
        }

        return result.ToArray();
    }

    //static void Main(string[] args)
    //{
    //    Merge_Intervals obj = new Merge_Intervals();
    //    int[][] intervals = new int[][] {
    //        new int[] { 1, 3 },
    //        new int[] { 2, 6 },
    //        new int[] { 8, 10 },
    //        new int[] { 15, 18 }
    //    };
        
    //    int[][] mergedIntervals = obj.Merge(intervals);

    //    foreach (int[] interval in mergedIntervals)
    //    {
    //        Console.WriteLine($"[{interval[0]}, {interval[1]}]");
    //    }
    //}
}
    }

