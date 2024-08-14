namespace MyLeetcode.DP
{
    internal static class _0322_CoinChange
    {
        public static int Run(int[] coins, int amount)
        {
            int[] f = new int[amount + 1];

            for (int i = 1; i <= amount; i++)
            {
                int min = int.MaxValue;
                foreach (int coin in coins)
                {
                    if (i >= coin && f[i - coin] != -1)
                    {
                        min = Math.Min(min, f[i - coin] + 1);
                    }
                }
                f[i] = min == int.MaxValue ? -1 : min;
            }

            return f[amount];
        }
    }
}