namespace MyLeetcode.DP
{
    internal static class _0070_ClimbingStairs
    {
        public static int Run(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 2;
            }

            int temp1 = 1;
            int temp2 = 2;
            int cur = 0;
            for (int i = 2; i < n; i++)
            {
                cur = temp1 + temp2;
                temp1 = temp2;
                temp2 = cur;
            }

            return temp2;
        }
    }
}
