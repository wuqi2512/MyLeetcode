namespace MyLeetcode.DP
{
    internal static class _0516_LongestPalindromicSubsequence
    {
        public static int Run(string s)
        {
            int strLength = s.Length;
            int[,] f = new int[strLength, strLength];
            for (int i = strLength - 1; i >= 0; i--)
            {
                f[i, i] = 1;
                for (int j = i + 1; j < strLength; j++)
                {
                    if (s[i] == s[j])
                    {
                        f[i, j] = f[i + 1, j - 1] + 2;
                    }
                    else
                    {
                        f[i, j] = Math.Max(f[i + 1, j], f[i, j - 1]);
                    }
                }
            }

            return f[0, strLength - 1];
        }
    }
}
