namespace MyLeetcode.DP
{
    internal static class _0064_MinimumPathSum
    {
        public static int Run(int[][] grid)
        {
            int row = grid.Length;
            int col = grid[0].Length;
            int[] f = new int[col];

            f[0] = grid[0][0];
            for (int i = 1; i < col; i++)
            {
                f[i] = f[i - 1] + grid[0][i];
            }

            for (int i = 1; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    int pre = f[j];
                    if (j - 1 >= 0)
                    {
                        pre = Math.Min(pre, f[j - 1]);
                    }

                    f[j] = pre + grid[i][j];
                }
            }

            return f[col - 1];
        }
    }
}
