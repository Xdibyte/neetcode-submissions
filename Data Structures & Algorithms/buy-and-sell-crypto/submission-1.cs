public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int i = 0;
        int j = 1;
        int max = 0;
        while(i < prices.Length && j < prices.Length)
        {
            int profit = prices[j] - prices[i];
            if(profit >= max)
            {
                max = profit;
            }
            if(prices[i] > prices[j])
            {
                i++;
            }
            else
            {
                j++;
            }
        }
        return max;
    }
}
