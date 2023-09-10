namespace LeetBoi.Easy
{
    internal static class Problem13
    {
        public static Dictionary<char, int> romanDict = new() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
        //problem 13
        public static int RomanToInt(string s)
        {
            int number = 0;
            int sign = 1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                number += sign * romanDict[s[i]];
                sign = i > 0 && romanDict[s[i - 1]] < romanDict[s[i]] ? -1 : 1;
            }

            return number;
        }
    }
}