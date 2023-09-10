namespace LeetBoi.Easy
{
    internal static class Problem67
    {

        //problem 67
        public static string AddBinary(string a, string b)
        {
            if (a.Length < b.Length)
            {
                a = new string(Enumerable.Repeat('0', b.Length - a.Length).ToArray()) + a;
            }

            if (b.Length < a.Length)
            {
                b = new string(Enumerable.Repeat('0', a.Length - b.Length).ToArray()) + b;
            }

            var c = new List<char>();
            var leftOver = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                var aNum = a[i] == '1' ? 1 : 0;
                var bNum = b[i] == '1' ? 1 : 0;

                int s;
                int sum = aNum + bNum + leftOver;
                if (sum > 1)
                {
                    s = sum == 3 ? 1 : 0;
                    leftOver = 1;
                }
                else
                {
                    s = aNum + bNum + leftOver;
                    leftOver = 0;
                }

                c.Add((char)(s + 48));
            }

            if (leftOver == 1)
            {
                c.Add('1');
            }
            c.Reverse();
            return new string(c.ToArray());

        }
    }
}