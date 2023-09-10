namespace LeetBoi.Easy
{
    internal static class Problem58
    {

        //problem 58
        public static int LengthOfLastWord(string s)
        {
            int num = 0;
            int lastNonSpaceIndex = s.Length - 1;
            while (s[lastNonSpaceIndex] == ' ')
            {
                lastNonSpaceIndex--;
            }

            while (lastNonSpaceIndex > -1 && s[lastNonSpaceIndex] != ' ')
            {
                lastNonSpaceIndex--;
                num++;
            }

            return num;
        }
    }
}