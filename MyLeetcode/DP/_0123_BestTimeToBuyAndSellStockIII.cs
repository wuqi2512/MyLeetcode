namespace MyLeetcode.DP
{
    internal static class _0123_BestTimeToBuyAndSellStockIII
    {
        public static int Run(int[] prices)
        {
            int ans = 0;
            for (int i = 1; i < prices.Length - 1; i++)
            {
                int left = Temp(prices, 0, i);
                int right = Temp(prices, i + 1, prices.Length - 1);
                ans = Math.Max(ans, left + right);
            }

            return ans;
        }

        private static int Temp(int[] array, int start, int end)
        {
            int ans = 0;
            int min = array[start];

            for (int i = start + 1; i <= end; i++)
            {
                if (array[i] > min)
                {
                    ans = Math.Max(ans, array[i] - min);
                }
                else
                {
                    min = array[i];
                }
            }

            return ans;
        }
    }
}
