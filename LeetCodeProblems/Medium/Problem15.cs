namespace LeetBoi.Medium
{
    internal static class Problem15
    {

        public static int BinarySearch(int[] arr, int l, int x)
        {
            int r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                if (arr[m] == x)
                    return m;

                if (arr[m] < x)
                    l = m + 1;

                else
                    r = m - 1;
            }

            return -1;
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();

            Array.Sort(nums);

            for (int i = 0; i < nums.Length && nums[i] < 1; i++)
            {

                for (int j = i + 1; j < nums.Length && nums[i] + nums[j] < 1; j++)
                {
                    int k = BinarySearch(nums, j + 1, (nums[i] + nums[j]) * -1);
                    if (k != -1)
                    {
                        var newTriplet = new List<int> { nums[i], nums[j], nums[k] };
                        var alreadyExists = false;

                        for (int i1 = result.Count - 1; i1 >= 0; i1--)
                        {
                            IList<int> triplet = result[i1];
                            if (triplet[0] == newTriplet[0] && triplet[1] == newTriplet[1] && triplet[2] == newTriplet[2])
                            {
                                alreadyExists = true;
                                break;
                            }
                        }

                        if (!alreadyExists)
                        {
                            result.Add(newTriplet);
                        }
                    }
                }
            }

            return result;
        }
    }
}