namespace LeetBoi.Medium
{
    internal static class Problem5
    {


        public static string LongestPalindrome(string s)
        {
            if (s.Length == 1)
            {
                return s;
            }

            var longestSubstring = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = s.Length - 1; j > 0; j--)
                {
                    var isPal = true;
                    var x = i;
                    var y = j;
                    while (y > x)
                    {
                        if (s[x] != s[y])
                        {
                            isPal = false;
                            break;
                        }
                        x++;
                        y--;
                    }

                    if (isPal && j - i + 1 > longestSubstring.Length)
                    {
                        longestSubstring = s.Substring(i, j - i + 1);
                    }
                }
            }

            return longestSubstring.Length == 0 ? s.Substring(0, 1) : longestSubstring;
        }
    }
}