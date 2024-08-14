namespace MyLeetcode.DP
{
    internal static class _0063_UniquePathsII
    {
        public static int Run(int[][] obstacleGrid)
        {
            int row = obstacleGrid.Length;
            int col = obstacleGrid[0].Length;
            int[] f = new int[col];
            f[0] = obstacleGrid[0][0] == 0 ? 1 : 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (obstacleGrid[i][j] == 1)
                    {
                        f[j] = 0;
                        continue;
                    }

                    if (j - 1 >= 0)
                    {
                        f[j] += f[j - 1];
                    }
                }
            }

            return f[col - 1];
        }
    }
}
