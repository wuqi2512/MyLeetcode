namespace MyLeetcode.DP
{
    internal static class _0055_JumpGame
    {
        public static bool Run(int[] nums)
        {
            bool[] arrive = new bool[nums.Length];
            arrive[0] = true;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (!arrive[j])
                    {
                        continue;
                    }

                    if (nums[j] + j >= i)
                    {
                        arrive[i] = true;
                        break;
                    }
                }
            }

            return arrive[arrive.Length - 1];
        }
    }
}
