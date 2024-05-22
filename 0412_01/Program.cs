using System;
using System.Collections.Generic;

internal class Program
{
    class Student
    {
        public string Name;
        public int Grade;
    }

    private static List<Student> list = new List<Student>()
    {
        new Student() { Name = "윤민성", Grade = 1 },
        new Student() { Name = "연하진", Grade = 2 },
        new Student() { Name = "윤아린", Grade = 3 },
        new Student() { Name = "윤명월", Grade = 4 },
        new Student() { Name = "구지연", Grade = 1 },
        new Student() { Name = "김연화", Grade = 2 }
    };

    private static void Main(string[] args)
    {
        ShowList(list);
        Console.WriteLine();
        Console.WriteLine("== 2학년 출력 ==");
        GradeFilter grade2Filter = new GradeFilter(2);
        grade2Filter.FilterAndDisplay(list);
        Console.WriteLine();
        Console.WriteLine("== 1학년 출력 ==");
        GradeFilter grade1Filter = new GradeFilter(1);
        grade1Filter.FilterAndDisplay(list);
    }

    private static void ShowList(List<Student> std)
    {
        foreach (var item in std)
        {
            Console.WriteLine($"{item.Name} : {item.Grade}");
        }
    }

    class GradeFilter
    {
        private int targetGrade;

        public GradeFilter(int grade)
        {
            targetGrade = grade;
        }

        public void FilterAndDisplay(List<Student> students)
        {
            foreach (var student in students)
            {
                if (student.Grade == targetGrade)
                {
                    Console.WriteLine($"{student.Name} : {student.Grade}");
                }
            }
        }
    }
}