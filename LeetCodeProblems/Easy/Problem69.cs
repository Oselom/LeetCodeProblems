namespace LeetBoi.Easy
{
    internal static class Problem69
    {

        //problem 69
        public static int MySqrt(int x)
        {
            double xCopy = x;
            double root;

            if (x == 0) return 0;

            while (true)
            {
                root = 0.5 * (xCopy + x / xCopy);

                double nearness = root - xCopy;
                nearness = nearness < 0 ? nearness * -1 : nearness;

                if (nearness < 1)
                    break;

                xCopy = root;
            }

            return (int)root;
        }
    }
}