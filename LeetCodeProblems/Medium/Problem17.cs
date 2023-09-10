namespace LeetBoi.Medium
{
    internal static class Problem17
    {

        public static Dictionary<char, char[]> phone = new()
        {
            { '2', new char[]{'a','b','c'} },
            { '3', new char[]{'d','e','f'} },
            { '4', new char[]{'g','h','i'} },
            { '5', new char[]{'j','k','l'} },
            { '6', new char[]{'m','n','o'} },
            { '7', new char[]{'p','q','r','s'} },
            { '8', new char[]{'t','u','v'} },
            { '9', new char[]{'w','x','y','z'} },
        };

        public static char[][] phoneArr = new[]
        {
            new char[]{'a','b','c'} ,
            new char[]{'d','e','f'} ,
            new char[]{'g','h','i'} ,
            new char[]{'j','k','l'} ,
            new char[]{'m','n','o'},
            new char[]{'p','q','r','s'} ,
            new char[]{'t','u','v'},
            new char[]{'w','x','y','z'},
        };

        public static IList<string> LetterCombinations(string digits)
        {
            if (digits == string.Empty) return new List<string>();

            IEnumerable<string> cartesianList = new List<string>() { "" };
            var listOfPossibilities = new List<char[]>();
            foreach (var c in digits)
            {
                int index = c - '0' - 2;
                cartesianList = from aggregate in cartesianList
                                from letter in phoneArr[index]
                                select aggregate + letter;
            }

            return cartesianList.ToList();
        }
    }
}