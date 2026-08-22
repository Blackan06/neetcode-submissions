public class Solution {
    public int MaxProfit(int[] prices) {
        int minBuy = prices[0]; //10
        int maxBuy = 0;
        int maxProfit = 0;
        for(int i = 1 ; i < prices.Length; i++){
              minBuy = Math.Min(minBuy, prices[i]);

              int currentProfit = prices[i] - minBuy;

               maxProfit = Math.Max(currentProfit, maxProfit);
        }

        return maxProfit;
       
        
    }
}

