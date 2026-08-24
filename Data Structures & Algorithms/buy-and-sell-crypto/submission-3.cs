public class Solution {
    public int MaxProfit(int[] prices) {
        int min = prices[0];
        int max = 0;

        foreach(var price in prices){
            min = Math.Min(min, price);
            int currentProfit = price - min;
            max = Math.Max(currentProfit, max);
        }

        return max;
    }
}
