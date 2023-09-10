using System.Text;

namespace LeetBoi.Easy
{
    internal static class Problem14
    {

        //problem 14
        public static string LongestCommonPrefix(string[] strs)
        {
            int minLength = strs.Min(s => s.Length);
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < minLength; i++)
            {
                if (!strs.All(st => st[i] == strs[0][i]))
                {
                    break;
                }
                stringBuilder.Append(strs[0][i]);
            }
            return stringBuilder.ToString();
        }
    }
}