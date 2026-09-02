class Solution {
    public int maxProfit(int[] prices) 
    {
        int maxprofit = 0;
        int l = 0;
        int r = 0;
        while(l <= r && r < prices.length)
        {
            int profit = prices[r] - prices[l];
            maxprofit = Math.max(profit, maxprofit);
            if(prices[l] > prices[r])
            {
                l++;
            }
            else
            {
                r++;
            }
        }
        return maxprofit;
    }
}
