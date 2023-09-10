namespace LeetBoi.Medium
{
    internal static class Problem8
    {

        public static int MyAtoi(string s)
        {
            if (s == string.Empty)
            {
                return 0;
            }

            var i = 0;
            while (s[i] == ' ')
            {
                i++;

                if (i == s.Length)
                {
                    return 0;
                }
            }

            int sign = 1;

            if (s[i] == '-')
            {
                sign = -1;
                i++;
            }
            else if (s[i] == '+')
            {
                i++;
            }

            if (i == s.Length)
            {
                return 0;
            }

            if (s[i] > '9' || s[i] < '0')
            {
                return 0;
            }

            long num = 0;

            while (s[i] >= '0' && s[i] <= '9')
            {
                num = num * 10 + (int)char.GetNumericValue(s[i]);
                i++;

                if (num * sign > int.MaxValue)
                {
                    return int.MaxValue;
                }

                if (num * sign < int.MinValue)
                {
                    return int.MinValue;
                }

                if (i == s.Length)
                {
                    break;
                }
            }

            return (int)num * sign;
        }
    }
}