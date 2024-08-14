namespace MyLeetcode.DP
{
    internal static class _0139_WordBreak
    {
        public static bool Run(string s, IList<string> wordDict)
        {
            bool[] f = new bool[s.Length + 1];
            f[0] = true;
            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (f[j] && wordDict.Contains(s.Substring(j, i - j)))
                    {
                        f[i] = true;
                        break;
                    }
                }
            }

            return f[s.Length];
        }
    }
}
