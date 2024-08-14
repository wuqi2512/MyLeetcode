namespace MyLeetcode.BackTracking
{
    internal static class _0046_Permutations
    {
        public static IList<IList<int>> Run(int[] nums)
        {
            bool[] flags = new bool[nums.Length];
            IList<IList<int>> result = new List<IList<int>>();
            List<int> cur = new List<int>();

            _0046_BackTracking(result, nums, flags, cur);

            return result;
        }

        private static void _0046_BackTracking(IList<IList<int>> result, int[] nums, bool[] flags, List<int> cur)
        {
            if (cur.Count == nums.Length)
            {
                result.Add(new List<int>(cur));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (flags[i])
                {
                    continue;
                }

                flags[i] = true;
                cur.Add(nums[i]);
                _0046_BackTracking(result, nums, flags, cur);
                cur.RemoveAt(cur.Count - 1);
                flags[i] = false;
            }
        }
    }
}
