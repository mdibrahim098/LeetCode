using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    //TC O(logn)
    //SC O(n)
    class Integer_Replacement
    {
        public int IntegerReplacement(int n)
        {
            Queue<long> queue = new Queue<long>();
            HashSet<long> seen = new HashSet<long>();
            queue.Enqueue(n);
            seen.Add(n);
            int result = 0;
            while (queue.Count != 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    long node = queue.Dequeue();
                    if (node == 1)
                    {
                        return result;
                    }
                    if (node % 2 == 0 && !seen.Contains(node / 2))
                    {
                        queue.Enqueue(node / 2);
                        seen.Add(node / 2);
                    }
                    else
                    {
                        if (!seen.Contains(node + 1))
                        {
                            queue.Enqueue(node+1);
                            seen.Add(node +1);
                        }
                        if (!seen.Contains(node - 1))
                        {
                            queue.Enqueue(node - 1);
                            seen.Add(node - 1);
                        }
                    }
                }
                result++;
               
                
            }
            return result;

        }
        // static void Main(string[] args)
        //{
        //    Integer_Replacement obj = new Integer_Replacement();
        //    int n = 8;
        //    Console.WriteLine(obj.IntegerReplacement(n));
        //    Console.ReadLine();

        //}

    }
}
