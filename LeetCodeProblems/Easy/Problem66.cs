namespace LeetBoi.Easy
{
    internal static class Problem66
    {

        //problem 66
        public static int[] PlusOne(int[] digits)
        {
            int i = digits.Length - 1;
            while (i >= 0)
            {
                if (digits[i] + 1 > 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i]++;
                    break;
                }
                i--;
            }

            if (digits[0] == 0)
            {
                var digitsArr = new int[digits.Length + 1];
                digitsArr[0] = 1;
                Array.Copy(digits, 0, digitsArr, 1, digits.Length);
                return digitsArr;
            }

            return digits;
        }
    }
}