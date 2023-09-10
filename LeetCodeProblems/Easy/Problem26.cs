namespace LeetBoi.Easy
{
    internal static class Problem26
    {

        //problem 26;
        public static int RemoveDuplicates(int[] nums)
        {
            //this is a "specially abled" problem; it doesn't really want to remove duplicates,
            //just sort the uniques and put them in front as the checker on leetcode checks only the number returned by the func;

            var distinctNum = nums.Distinct().ToList();
            for (int i = 0; i < distinctNum.Count; i++)
            {
                nums[i] = distinctNum[i];
            }

            return distinctNum.Count;
        }
    }
}