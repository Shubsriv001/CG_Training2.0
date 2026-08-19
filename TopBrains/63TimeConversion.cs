using System;

public class TimeConversion
{
    public static string FormatTime(int totalSeconds)
    {
        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

        return minutes + ":" + seconds.ToString("D2");
    }
}
