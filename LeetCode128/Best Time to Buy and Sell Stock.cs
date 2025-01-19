using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    //Approach 1 
    // TC O(n)
    // SC O(1)
    internal class Best_Time_to_Buy_and_Sell_Stock
    {

        public int MaxProfit(int[] prices)
        {
            int buyPrice = prices[0];
            int maxProfit = 0;
           for(int i=1; i< prices.Length; i++)
            {
                if(buyPrice> prices[i])
                {
                    buyPrice = prices[i];

                }
                else
                {
                    int currentProfit = prices[i]-buyPrice;
                    maxProfit = Math.Max(maxProfit, currentProfit);
                }
            }
           return maxProfit;
        }
       /* static void Main(string[] args)
        {
            Best_Time_to_Buy_and_Sell_Stock obj = new Best_Time_to_Buy_and_Sell_Stock();
            int[] prices = {7, 1, 5, 3, 6, 4};
            Console.WriteLine(obj.MaxProfit(prices));
        }*/
    }
}
