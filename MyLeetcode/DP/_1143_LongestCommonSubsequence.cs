namespace MyLeetcode.DP
{
    internal static class _1143_LongestCommonSubsequence
    {
        public static int Run(string text1, string text2)
        {
            int[,] f = new int[text1.Length + 1, text2.Length + 1];

            for (int i = 1; i <= text1.Length; i++)
            {
                for (int j = 1; j <= text2.Length; j++)
                {
                    if (text1[i - 1] == text2[j - 1])
                    {
                        f[i, j] = f[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        f[i, j] = Math.Max(f[i - 1, j], f[i, j - 1]);
                    }
                }
            }

            return f[text1.Length, text2.Length];
        }
    }
}