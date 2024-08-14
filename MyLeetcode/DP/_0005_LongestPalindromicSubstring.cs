namespace MyLeetcode.DP
{
    internal static class _0005_LongestPalindromicSubstring
    {
        public static string Run(string s)
        {
            int maxLength = 1;
            int startIndex = 0;
            int strLength = s.Length;
            bool[,] f = new bool[strLength, strLength];
            for (int i = 0; i < strLength; i++)
            {
                f[i, i] = true;
            }

            for (int len = 2; len <= strLength; len++)
            {
                for (int i = 0; i < strLength; i++)
                {
                    int j = i + len - 1;
                    if (j >= strLength)
                    {
                        break;
                    }

                    if ((f[i + 1, j - 1] || len == 2) && s[i] == s[j])
                    {
                        f[i, j] = true;
                        if (len > maxLength)
                        {
                            maxLength = len;
                            startIndex = i;
                        }
                    }
                }
            }

            return s.Substring(startIndex, maxLength);
        }
    }
}
