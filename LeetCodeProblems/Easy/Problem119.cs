namespace LeetBoi.Easy
{
    internal static class Problem119
    {

        public static IList<int> GenerateXPascal(int rowIndex)
        {
            IList<int> lst = new List<int>(rowIndex + 1)
            {
                1
            };
            for (int k = 1; k < rowIndex / 2 + 1; k++)
            {
                long res = (rowIndex - k + 1) * (long)lst[k - 1] / k;
                lst.Add((int)res);
            }

            for (int i = lst.Count - 1 - (rowIndex + 1) % 2; i >= 0; i--)
            {
                lst.Add(lst[i]);
            }

            return lst;
        }
    }
}