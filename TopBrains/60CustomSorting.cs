using System;
using System.Collections.Generic;
using System.Linq;

public class StudentEntity
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

public class CustomSort
{
    public static List<StudentEntity> SortStudents(List<StudentEntity> students)
    {
        return students
            .OrderByDescending(s => s.Marks)
            .ThenBy(s => s.Age)
            .ToList();
    }
}
