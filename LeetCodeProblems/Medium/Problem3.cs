namespace LeetBoi.Medium
{
    internal static class Problem3
    {

        public static int LengthOfLongestSubstring(string s)
        {
            var longest = 0;
            var temp = new LinkedList<char>();
            var j = 0;

            for (j = 0; j < s.Length; j++)
            {
                while (temp.Contains(s[j]))
                {
                    temp.RemoveFirst();
                }

                temp.AddLast(s[j]);

                if (longest < temp.Count)
                {
                    longest = temp.Count;
                }
            }

            return longest;
        }
    }
}