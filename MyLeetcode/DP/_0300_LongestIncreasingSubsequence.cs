namespace MyLeetcode.DP
{
    internal static class _0300_LongestIncreasingSubsequence
    {
        public static int Run(int[] nums)
        {
            int ans = 0;
            int[] f = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int value = 0;
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        value = Math.Max(value, f[j]);
                    }
                }
                f[i] = value + 1;
                ans = Math.Max(ans, f[i]);
            }

            return ans;
        }
    }
}
