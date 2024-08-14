namespace MyLeetcode.DP
{
    internal static class _0072_EditDistance
    {
        public static int Run(string word1, string word2)
        {
            int n1 = word1.Length;
            int n2 = word2.Length;

            int[,] f = new int[n1 + 1, n2 + 1];

            for (int i = 0; i <= n1; i++)
            {
                f[i, 0] = i;
            }
            for (int i = 0; i <= n2; i++)
            {
                f[0, i] = i;
            }

            for (int i = 1; i <= n1; i++)
            {
                for (int j = 1; j <= n2; j++)
                {
                    int left = f[i, j - 1] + 1;
                    int up = f[i - 1, j] + 1;
                    int leftUp = f[i - 1, j - 1];
                    if (word1[i - 1] != word2[j - 1])
                    {
                        leftUp++;
                    }
                    f[i, j] = Math.Min(left, Math.Min(up, leftUp));
                }
            }

            return f[n1, n2];
        }
    }
}