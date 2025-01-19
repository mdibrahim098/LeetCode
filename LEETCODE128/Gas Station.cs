using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    //TC O(n)
    //SC O(1)
    class Gas_Station
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int total_gas = 0;
            int total_cost =0;
            int n = gas.Length;
            int current = 0;
            int start = 0;
            for (int i = 0; i < n; i++)
            {
                total_gas = gas[i];
            }
            for (int i = 0; i < n; i++)
            {
                total_cost = cost[i];
            }
            if (total_gas < total_cost)
            {
                return -1;
            }
            for (int i = 0; i < n; i++)
            {
                current += gas[i] - cost[i];
                if (current < 0)
                {
                    start = i + 1;
                    current = 0;
                }
            }
            return start;

        }
        
       //static void Main(string[] args)
       // {
       //     Gas_Station obj = new Gas_Station();
       //     int[] gas = { 1, 2, 3, 4, 5 };
       //     int[] cost = {3,4,5,1,2};
       //     Console.WriteLine(obj.CanCompleteCircuit(gas,cost));
       // }
    }
}
