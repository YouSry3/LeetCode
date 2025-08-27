public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach (int price in prices) {
            if (price < minPrice) {
                minPrice = price; // buy at lower price
            } else {
                maxProfit = Math.Max(maxProfit, price - minPrice); // sell for profit
            }
        }

        return maxProfit;
    }
}
