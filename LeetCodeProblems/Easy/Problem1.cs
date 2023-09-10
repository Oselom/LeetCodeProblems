using LeetBoi.ZHelpers;

namespace LeetBoi.Easy
{
    internal static class Problem1
    {

        /*
         * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

           You may assume that each input would have exactly one solution, and you may not use the same element twice.

           You can return the answer in any order.
         */
        public static int[] TwoSum(int[] nums, int target)
        {
            //this is faster than the original solution of searching like a brute at the cost of memory
            //maybe the memory usage would be lower by writing the sort and having it keep track of indices as it goes but I don't want to do that
            var sorted = nums
                .Select((num,index) => new {num,index})
                .OrderBy(x => x.num)
                .ToArray();
            var sortedNums = sorted
                .Select(x => x.num)
                .ToArray();
            var originalIndicesByCurrentIndices = sorted
                .Select((x, i) => new { x.index, i })
                .ToDictionary(num => num.i, num => num.index);

            for (int i = 0; i < sortedNums.Length; i++)
            {
                int k = target - sortedNums[i];
                int position = BinarySearch.Search(sortedNums, i + 1, k);
                if (position != -1)
                {
                    return new int[] { originalIndicesByCurrentIndices[i], originalIndicesByCurrentIndices[position] };
                }
            }

            return new int[] { -1, -1 };
        }
    }
}