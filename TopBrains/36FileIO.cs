using System;
using System.IO;

public class FileIO
{
    public static void Main()
    {
        string[] lines = File.ReadAllLines("log.txt");

        using (StreamWriter writer = new StreamWriter("error.txt"))
        {
            foreach (string line in lines)
            {
                if (line.Contains("ERROR"))
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
