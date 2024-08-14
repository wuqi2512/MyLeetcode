namespace MyLeetcode.DP
{
    internal static class _0053_MaximumSubarray
    {
        public static int Run(int[] nums)
        {
            int ans = nums[0];
            int cur = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                cur = Math.Max(cur + nums[i], nums[i]);
                ans = Math.Max(ans, cur);
            }

            return ans;
        }
    }
}
