namespace LeetBoi.Hard
{
    internal static class Problem10
    {

        public static bool IsMatch(string s, string p)
        {
            var rules = new List<(int RuleType, char? RuleChar)>();
            //rule 0 - match zero or more any characters
            //rule 1 - match zero or more of a specific character
            //rule 2 - match any single character
            //rule 3 - match a specific character

            var i = 0;
            while (i < p.Length - 1)
            {
                if (p[i + 1] == '*')
                {
                    if (p[i] == '.')
                    {
                        rules.Add((0, null));
                    }
                    else
                    {
                        rules.Add((1, p[i]));
                    }
                    i++;
                }
                else
                {
                    if (p[i] == '.')
                    {
                        rules.Add((2, null));
                    }
                    else
                    {
                        rules.Add((3, p[i]));
                    }
                }
                i++;
            }

            if (i != p.Length && p[i] != '*')
            {
                if (p[i] == '.')
                {
                    rules.Add((2, null));
                }
                else
                {
                    rules.Add((3, p[i]));
                }
            }

            i = 0;
            for (int j = 0; j < s.Length; j++)
            {
                switch (rules[i].RuleType)
                {
                    case 0:
                        return true;
                    case 1:
                        int it = 0;
                        while (j < s.Length && s[j] == rules[i].RuleChar)
                        {
                            j++;
                            it++;
                        }
                        if (it > 0) j--;
                        break;
                    case 2:
                        j++;
                        break;
                    case 3:
                        if (s[j] != rules[i].RuleChar)
                        {
                            return false;
                        }
                        break;
                }


                i++;
                if (j == s.Length && i != rules.Count)
                {
                    return false;
                }

                if (i == rules.Count && j != s.Length)
                {
                    return false;
                }
            }

            return true;
        }
    }
}