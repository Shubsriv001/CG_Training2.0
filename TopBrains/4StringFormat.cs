using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public record Student(string Name, int Score);

public class StringFormat
{
    public static string GetStudentsJson(string[] items, int minScore)
    {
        List<Student> students = new List<Student>();

        foreach (string item in items)
        {
            string[] parts = item.Split(':');

            string name = parts[0];
            int score = int.Parse(parts[1]);

            Student student = new Student(name, score);
            students.Add(student);
        }

        List<Student> result = students
            .Where(s => s.Score >= minScore)
            .OrderByDescending(s => s.Score)
            .ThenBy(s => s.Name)
            .ToList();

        string json = JsonSerializer.Serialize(result);

        return json;
    }
}
