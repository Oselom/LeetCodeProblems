namespace LeetBoi.Easy
{
    internal class Problem20
    {
        public static Dictionary<char, char> paranthesis = new() { { ')', '(' }, { '}', '{' }, { ']', '[' } };
        public static char[] openParanthesis = new char[] { '(', '{', '[' };
        public static char[] closeParanthesis = new char[] { ')', '}', ']' };

        public static bool IsValid(string s)
        {
            if(closeParanthesis.Contains(s[0]) || s.Length % 2 != 0)
            {
                return false;
            }

            var stack = new Stack<int>();

            foreach (var c in s)
            {
                var index = Array.IndexOf(openParanthesis, c);
                if (index != -1)
                {
                    stack.Push(index);
                    continue;
                }

                var clIndex = Array.IndexOf(closeParanthesis, c);
                if (stack.Count == 0 || stack.Pop() != clIndex)
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
