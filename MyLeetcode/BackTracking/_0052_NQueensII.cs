namespace MyLeetcode.BackTracking
{
    internal static class _0052_NQueensII
    {
        public static int Run(int n)
        {
            bool[][] flags = new bool[3][];
            flags[0] = new bool[n];
            flags[1] = new bool[2 * n - 1];
            flags[2] = new bool[2 * n - 1];

            return _0052_BackTracking(flags, 0, n);
        }

        private static int _0052_BackTracking(bool[][] flags, int row, int n)
        {
            if (row == n)
            {
                return 1;
            }

            int ans = 0;
            for (int col = 0; col < n; col++)
            {
                if (flags[0][col] || flags[1][row - col + n - 1] || flags[2][row + col])
                {
                    continue;
                }

                flags[0][col] = true;
                flags[1][row - col + n - 1] = true;
                flags[2][row + col] = true;

                ans += _0052_BackTracking(flags, row + 1, n);

                flags[0][col] = false;
                flags[1][row - col + n - 1] = false;
                flags[2][row + col] = false;
            }

            return ans;
        }
    }
}
