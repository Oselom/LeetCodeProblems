using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetBoi.ZHelpers
{
    internal static class BinarySearch
    {
        public static int Search(int[] arr, int l, int x)
        {
            int r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                if (arr[m] == x)
                    return m;

                if (arr[m] < x)
                    l = m + 1;

                else
                    r = m - 1;
            }

            return -1;
        }

        public static int Search(IList<int> arr, int l, int x)
        {
            int r = arr.Count - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                if (arr[m] == x)
                    return m;

                if (arr[m] < x)
                    l = m + 1;

                else
                    r = m - 1;
            }

            return -1;
        }
    }
}
