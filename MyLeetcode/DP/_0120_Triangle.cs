namespace MyLeetcode.DP
{
    internal static class _0120_Triangle
    {
        public static int Run(IList<IList<int>> triangle)
        {
            int n = triangle.Count;
            int[] f = new int[n];
            for (int i = 0; i < n; i++)
            {
                f[i] = triangle[n - 1][i];
            }

            for (int i = n - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    f[j] = Math.Min(f[j], f[j + 1]) + triangle[i][j];
                }
            }

            return f[0];
        }
    }
}
