using System;
using System.Globalization;

public class InventoryNameCleanup
{
    public static string ProcessProductName(string name)
    {
        name = name.Trim();

        string result = "";

        for (int i = 0; i < name.Length; i++)
        {
            if (i == 0 || name[i] != name[i - 1])
            {
                result += name[i];
            }
        }

        result = result.Trim();

        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        result = textInfo.ToTitleCase(result.ToLower());

        return result;
    }
}
