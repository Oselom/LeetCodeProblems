using System.Text;

namespace LeetBoi.Medium
{
    internal static class Problem12
    {

        public static (int, string)[] romanDict = new[] {
            ( 1, "I" ),
            ( 4, "IV" ),
            (5, "V"),
            (9, "IX"),
            (10, "X"),
            (40, "XL"),
            (50, "L"),
            (90, "XC"),
            (100, "C"),
            (400, "CD"),
            (500, "D"),
            (900, "CM"),
            (1000, "M")
        };
        public static int[] numArr = new int[] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };

        public static string IntToRoman(int num)
        {
            var stringBuilder = new StringBuilder();
            var currentKeyIndex = FindInsertPos(numArr, numArr.Length, num);
            while (num != 0)
            {
                var currentKey = romanDict[currentKeyIndex].Item1;
                var currentValue = romanDict[currentKeyIndex].Item2;
                while (num >= currentKey)
                {
                    num -= currentKey;
                    stringBuilder.Append(currentValue);
                }
                currentKeyIndex = FindInsertPos(numArr, currentKeyIndex, num);
            }

            return stringBuilder.ToString();
        }

        public static int FindInsertPos(int[] arr, int n, int K)
        {
            int start = 0;
            int end = n - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (arr[mid] == K)
                    return mid;

                else if (arr[mid] < K)
                    start = mid + 1;

                else
                    end = mid - 1;
            }

            return end;
        }
    }
}