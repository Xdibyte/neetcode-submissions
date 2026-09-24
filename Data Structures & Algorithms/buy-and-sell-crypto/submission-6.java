class Solution {
    public int maxProfit(int[] prices) 
    {
        int maxprofit = 0;
        int i = 0;
        int j = 1;
        while(j < prices.length)
        {
            int profit = prices[j] - prices[i];
            maxprofit = Math.max(maxprofit, profit);
            if(prices[i] > prices[j])
            {
                i++;
            }
            else
            {
                j++;
            }
        }
        return maxprofit;
    }
}
