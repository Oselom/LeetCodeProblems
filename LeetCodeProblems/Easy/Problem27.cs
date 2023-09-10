namespace LeetBoi.Easy
{
    internal static class Problem27
    {

        //problem 27;
        public static int RemoveElement(int[] nums, int val)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[j] = nums[i];
                    j++;
                }
            }

            return j;
        }
    }
}