namespace LeetBoi.Easy
{
    internal static class Problem70
    {

        //problem 70
        public static int ClimbStairs(int n)
        {
            int a = 0, b = 1;

            for (int i = 2; i <= n + 1; i++)
            {
                int aux = a + b;
                a = b;
                b = aux;
            }

            return b;
        }
    }
}