namespace LeetBoi.Easy
{
    internal static class Problem88
    {

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                int j = 0;
                while (nums2[i] > nums1[j] && j < m)
                {
                    j++;
                }
                for (int k = m + n - 1; k > j; k--)
                {
                    nums1[k] = nums1[k - 1];
                }
                nums1[j] = nums2[i];
            }
        }
    }
}