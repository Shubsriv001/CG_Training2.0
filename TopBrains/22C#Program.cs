using System;

public class Programs
{
    public static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        string result = "";

        foreach (char ch in first)
        {
            char lower = char.ToLower(ch);

            bool isVowel = lower == 'a' || lower == 'e' ||
                           lower == 'i' || lower == 'o' ||
                           lower == 'u';

            bool common = false;

            foreach (char c in second)
            {
                if (lower == char.ToLower(c))
                {
                    common = true;
                    break;
                }
            }

            if (!isVowel && common)
            {
                continue;
            }

            if (result.Length > 0 &&
                char.ToLower(result[result.Length - 1]) == lower)
            {
                continue;
            }

            result += ch;
        }

        Console.WriteLine(result);
    }
}
