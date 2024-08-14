namespace MyLeetcode.Greedy
{
    internal static class _0452_MiniumNumberOfArrowsToBurstBallons
    {
        public static int Run(int[][] points)
        {
            Array.Sort(points, (a, b) =>
            {
                return a[1].CompareTo(b[1]);
            });

            int lastMax = points[0][1];
            int count = 1;
            for (int i = 1; i < points.Length; i++)
            {
                if (lastMax < points[i][0])
                {
                    count++;
                    lastMax = points[i][1];
                }
            }

            return count;
        }
    }
}
