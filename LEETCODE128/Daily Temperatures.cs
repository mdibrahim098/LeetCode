using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    class Daily_Temperatures
    {
        //TC O(n)
        //SC O(n)
        public int[] DailyTemperatures(int[] temperatures)
        {
            Stack<int> stack = new Stack<int>();
            int n = temperatures.Length;
            int[] result = new int[n];
            for (int i = n - 1; i >= 0; i--)
            {
                while (stack.Count != 0 && temperatures[stack.Peek()] <= temperatures[i])
                {
                    stack.Pop();
                }
                if (stack.Count != 0)
                {
                    result[i] = stack.Peek() - i;
                }
                stack.Push(i);
            }
            return result;
        }
        //static void Main(string[] args)
        //{
        //    Daily_Temperatures obj = new Daily_Temperatures();
        //    int[] temperatures = {73,74,75,71,69,72,76,73};
        //    Console.WriteLine(string.Join(",",obj.DailyTemperatures(temperatures)));
        //}
    }
}
