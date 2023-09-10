namespace LeetBoi.Medium
{
    internal static class Problem16
    {

        public static int ThreeSumClosest(int[] nums, int target)
        {
            var closest = int.MaxValue;
            var distanceToClosest = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (var k = j + 1; k < nums.Length && distanceToClosest != 0; k++)
                    {
                        int distance = target - (nums[i] + nums[j] + nums[k]);

                        distance = distance < 0 ? distance * -1 : distance;

                        if (distance < distanceToClosest)
                        {
                            closest = nums[i] + nums[j] + nums[k];
                            distanceToClosest = distance;
                        }
                    }
                }
            }

            return closest;
        }
    }
}