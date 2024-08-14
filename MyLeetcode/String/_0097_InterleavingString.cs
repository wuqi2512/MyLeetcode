namespace MyLeetcode.String
{
    internal static class _0097_InterleavingString
    {
        public static bool Run(string s1, string s2, string s3)
        {
            int n1 = s1.Length;
            int n2 = s2.Length;
            int n3 = s3.Length;

            if (n1 + n2 != n3)
            {
                return false;
            }

            bool[] f = new bool[n2 + 1];
            f[0] = true;

            for (int i = 0; i <= n1; i++)
            {
                for (int j = 0; j <= n2; j++)
                {
                    if (i > 0)
                    {
                        f[j] &= s1[i - 1] == s3[i + j - 1];
                    }
                    if (j > 0 && s2[j - 1] == s3[i + j - 1])
                    {
                        f[j] |= f[j - 1];
                    }
                }
            }

            return f[n2];
        }
    }
}
