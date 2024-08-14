namespace MyLeetcode.BackTracking
{
    internal static class _0077_Combinations
    {
        public static IList<IList<int>> Run(int n, int k)
        {
            IList<IList<int>> result = new List<IList<int>>();
            IList<int> temp = new List<int>();

            _0077_BackTrack(result, temp, n, k, 1);

            return result;
        }

        private static void _0077_BackTrack(IList<IList<int>> result, IList<int> temp, int n, int k, int num)
        {
            if (temp.Count == k)
            {
                result.Add(new List<int>(temp));
                return;
            }

            if (num == n + 1)
            {
                return;
            }

            temp.Add(num);
            _0077_BackTrack(result, temp, n, k, num + 1);
            temp.RemoveAt(temp.Count - 1);
            _0077_BackTrack(result, temp, n, k, num + 1);
        }
    }
}
