namespace MyLeetcode.Greedy
{
    internal static class _0121_BestTimeToBuyAndSellStock
    {
        public static int Run(int[] prices)
        {
            int curMin = prices[0];
            int curMax = prices[0];
            int tempMin = int.MaxValue;
            int tempMax = int.MaxValue;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > curMax)
                {
                    curMax = prices[i];
                }
                else if (prices[i] < tempMin)
                {
                    tempMin = prices[i];
                    tempMax = prices[i];
                }

                if (prices[i] > tempMax)
                {
                    tempMax = prices[i];
                    if (tempMax - tempMin > curMax - curMin)
                    {
                        curMax = tempMax;
                        curMin = tempMin;
                        tempMin = int.MaxValue;
                        tempMax = int.MaxValue;
                    }
                }
            }

            return curMax - curMin;
        }
    }
}
