namespace MyLeetcode.Sort
{
    internal static class _0215_KthLargestElementInAnArray
    {
        public static int Run(int[] nums, int k)
        {
            for (int i = (nums.Length - 2) / 2; i >= 0; i--)
            {
                Sink(nums, i, nums.Length - 1);
            }

            for (int i = nums.Length - 1; i > nums.Length - k; i--)
            {
                Exchange(nums, 0, i);
                Sink(nums, 0, i - 1);
            }
            return nums[0];
        }

        private static void Sink(int[] nums, int start, int end)
        {
            int parent = start;
            int child = parent * 2 + 1;
            while (child <= end)
            {
                if (child + 1 <= end && nums[child] < nums[child + 1])
                    child++;
                if (nums[parent] >= nums[child])
                    return;

                Exchange(nums, parent, child);
                parent = child;
                child = parent * 2 + 1;
            }
        }

        private static void Exchange(int[] nums, int a, int b)
        {
            int temp = nums[a];
            nums[a] = nums[b];
            nums[b] = temp;
        }
    }
}
