using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    //TC O(n)
    //SC (n)
    class Remove_K_Digits
    {
        public string RemoveKdigits(string num, int k)
        {
            int n = num.Length;
            Stack<char> stack = new Stack<char>();

            foreach (char c in num)
            {
                while (k > 0 && stack.Count != 0 && stack.Peek() > c)
                {
                    stack.Pop();
                    k--;
                }
                stack.Push(c);
            }

            // If k is still greater than 0, remove the remaining elements from the end
            while (k > 0)
            {
                stack.Pop();
                k--;
            }

            // Construct the number from the stack
            StringBuilder sb = new StringBuilder();
            while (stack.Count != 0)
            {
                sb.Insert(0, stack.Pop());
            }

            // Remove leading zeros
            while (sb.Length > 0 && sb[0] == '0')
            {
                sb.Remove(0, 1);
            }

            return sb.Length == 0 ? "0" : sb.ToString();
        }
        //public static void Main(string[] args)
        //{
        //    Remove_K_Digits solution = new Remove_K_Digits();
        //    string num = "1432219";
        //    int k = 3;
        //    Console.WriteLine(solution.RemoveKdigits(num, k));  // Expected output: "1219"
        //}
    }
}
