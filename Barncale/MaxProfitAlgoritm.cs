namespace Tasks;

public static class MaxProfitAlgoritm
{
    public static int MaxProfit(int[] prices)
    {
        int profit = 0;
        int left = 0;
        for (int right = 1; right < prices.Length; right++)
        {
            if (prices[left] < prices[right])
            {
                var difference = prices[right] - prices[left];
                profit = Math.Max(profit, difference);
            }
            else
            {
                left = right;
            }
        }

        return profit;
    }
}