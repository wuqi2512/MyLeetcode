namespace MyLeetcode.BackTracking
{
    internal static class _0039_CombinationSum
    {
        public static IList<IList<int>> Run(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            List<int> cur = new List<int>();

            _0039_BackTracking(result, candidates, cur, target, 0);

            return result;
        }

        private static void _0039_BackTracking(IList<IList<int>> result, int[] candidates, List<int> cur, int curTarget, int index)
        {
            if (index == candidates.Length)
            {
                return;
            }

            if (curTarget == 0)
            {
                result.Add(new List<int>(cur));
                return;
            }

            _0039_BackTracking(result, candidates, cur, curTarget, index + 1);

            int value = candidates[index];
            if (value <= curTarget)
            {
                cur.Add(value);
                _0039_BackTracking(result, candidates, cur, curTarget - value, index);
                cur.RemoveAt(cur.Count - 1);
            }
        }
    }
}
