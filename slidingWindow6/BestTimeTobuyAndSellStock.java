package slidingWindow6;


//Approach 2


// Time Complexity O(n)
// Space Complexity O(1)
class BestTimeTobuyAndSellStock {

    public int maxProfit(int[] prices) {
    int left =0;
    int right = 1;
    int maxProfit =0;
    while(right<prices.length){
        if(prices[left]<prices[right]){
            int currentProfit = prices[right]-prices[left];
            maxProfit = Math.max(maxProfit, currentProfit);
        }else{
            left = right;
        
        }
        right++;
    }
    
 return maxProfit;
    }

    public static void main(String[] args) {
        BestTimeTobuyAndSellStock obj = new BestTimeTobuyAndSellStock();

        int[] prices = {7, 1, 5, 3, 6, 4};
        System.out.println(obj.maxProfit(prices));
    }
}

//Approace 1
// Time Complexity O(n)
// Space Complexity O(1)
/*
 class BestTimeTobuyAndSellStock {

    public int maxProfit(int[] prices) {
     int buyPrice = prices[0];
     int maxProfit = 0;
     for(int i=1; i<prices.length;i++){
         if(buyPrice>prices[i]){
             buyPrice = prices[i];
         }else{
             int currentProfit= prices[i] - buyPrice;
             maxProfit = Math.max(currentProfit, maxProfit);
         }
     }
     return maxProfit;
    }

    public static void main(String[] args) {
        BestTimeTobuyAndSellStock obj = new BestTimeTobuyAndSellStock();

        int[] prices = {7, 1, 5, 3, 6, 4};
        System.out.println(obj.maxProfit(prices));
    }
}

*/
