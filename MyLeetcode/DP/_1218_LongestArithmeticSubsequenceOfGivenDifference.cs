namespace MyLeetcode.DP
{
    internal static class _1218_LongestArithmeticSubsequenceOfGivenDifference
    {
        public static int Run(int[] arr, int difference)
        {
            int ans = 0;
            Dictionary<int, int> f = new Dictionary<int, int>();

            foreach (int value in arr)
            {
                int prev = 0;
                if (f.ContainsKey(value - difference))
                {
                    prev = f[value - difference];
                }
                f[value] = prev + 1;
                ans = Math.Max(ans, prev + 1);
            }

            return ans;
        }
    }
}
