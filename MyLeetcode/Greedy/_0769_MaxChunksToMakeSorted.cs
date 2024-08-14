namespace MyLeetcode.Greedy
{
    internal static class _0769_MaxChunksToMakeSorted
    {
        public static int Run(int[] arr)
        {
            int result = 0;
            int right = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                right = Math.Max(right, arr[i]);
                if (right == i)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
