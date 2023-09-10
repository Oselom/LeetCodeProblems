namespace LeetBoi.Easy
{
    internal static class Problem9
    {

        //problem 9
        public static bool IsPalindrome(int x)
        {
            int numOfDigits = 0;
            int y = x;
            while (y != 0)
            {
                y /= 10;
                numOfDigits++;
            }

            if (x < 0) return false;

            while (x != 0)
            {
                int toGetFirstDigit = (int)Math.Pow(10, numOfDigits - 1);
                int firstDigit = x / toGetFirstDigit;

                if (x % 10 != firstDigit)
                    return false;

                x = (x - firstDigit * toGetFirstDigit) / 10;

                numOfDigits -= 2;
            }

            return true;
        }
    }
}