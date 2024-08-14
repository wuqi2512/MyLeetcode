namespace MyLeetcode.DP
{
    internal static class _0712_MinimumAsciiDeleteSumForTwoStrings
    {
        public static int Run(string s1, string s2)
        {
            int[,] f = new int[s1.Length + 1, s2.Length + 1];
            for (int i = 1; i <= s1.Length; i++)
            {
                f[i, 0] = f[i - 1, 0] + s1[i - 1];
            }
            for (int i = 1; i <= s2.Length; i++)
            {
                f[0, i] = f[0, i - 1] + s2[i - 1];
            }
            for (int i = 1; i <= s1.Length; i++)
            {
                char temp1 = s1[i - 1];
                for (int j = 1; j <= s2.Length; j++)
                {
                    char temp2 = s2[j - 1];
                    if (temp1 == temp2)
                    {
                        f[i, j] = f[i - 1, j - 1];
                    }
                    else
                    {
                        f[i, j] = Math.Min(f[i, j - 1] + temp2, f[i - 1, j] + temp1);
                    }
                }
            }

            return f[s1.Length, s2.Length];
        }
    }
}
