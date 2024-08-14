namespace MyLeetcode.DP
{
    internal static class _0377_CombinationSumIV
    {
        public static int Run(int[] nums, int target)
        {
            int[] f = new int[target + 1];
            f[0] = 1;
            for (int i = 1; i < f.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i >= nums[j])
                    {
                        f[i] += f[i - nums[j]];
                    }
                }
            }

            return f[target];
        }
    }
}
