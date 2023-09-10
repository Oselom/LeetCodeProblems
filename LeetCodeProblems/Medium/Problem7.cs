namespace LeetBoi.Medium
{
    internal static class Problem7
    {

        public static int Reverse(int x)
        {
            var rev = 0;

            if (x / 1_000_000_000 != 0)
            {
                while (x != 0)
                {
                    var prevRev = rev;
                    rev = rev * 10 + x % 10;
                    if (prevRev / 10 != rev / 100)
                    {
                        return 0;
                    }
                    x /= 10;
                }
                return rev;
            }

            while (x != 0)
            {
                rev = rev * 10 + x % 10;
                x /= 10;
            }
            return rev;
        }
    }
}