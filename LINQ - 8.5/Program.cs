using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

namespace MiniExercise5_StudentMarksReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mini Exercise 5: Student Marks Report");
            Console.WriteLine("-------------------------------------");

            Run();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static void Run()
        {
            var students = new List<Student>
          {
              new Student("Alice",  78),
              new Student("Bob",    92),
              new Student("Charlie",65),
              new Student("Diana",  88),
              new Student("Ethan",  55),
              new Student("Farah",  81),
              new Student("Greg",   49),
              new Student("Hannah", 73)
          };

            
            Console.WriteLine("PART A: For loop (marks >= 80)");
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Mark >= 80)
                {
                    Console.WriteLine($"Mark >= 80 found: {students[i].Mark} ({students[i].Name})");
                }
            }

        
            Console.WriteLine("  PART B: LINQ Method Syntax");
  

            Console.WriteLine("  1) Passed students(>= 70):");
  
            var passedStudents = students.Where(s => s.Mark >= 70);

            foreach (var s in passedStudents)
                Console.WriteLine($"{s.Name} - {s.Mark}");

            Console.WriteLine("  2) Names of passed students:");
            var passedNames = passedStudents.Select(s => s.Name).ToList();
            Console.WriteLine(string.Join(", ", passedNames));

            Console.WriteLine("  3) Sorted students(Mark desc, Name asc):");
            var sortedStudents = students
              .OrderByDescending(s => s.Mark)
              .ThenBy(s => s.Name);

            foreach (var s in sortedStudents)
                Console.WriteLine($"{s.Name} - {s.Mark}");

            Console.WriteLine("  4) Aggregates: ");
            int totalStudents = students.Count();
            bool anyFailed = students.Any(s => s.Mark < 50);
            double averageMark = students.Average(s => s.Mark);

            Console.WriteLine($"Total students: {totalStudents}");
            Console.WriteLine($"Any failed (< 50)? {anyFailed}");
            Console.WriteLine($"Average mark: {averageMark:F1}");

       
            Console.WriteLine("  PART C: LINQ Query Syntax");
  

            var topMarksQuery =
                from s in students
                where s.Mark >= 80
                select s.Mark;

            Console.WriteLine("  Marks >= 80(Query Syntax):");
            foreach (var m in topMarksQuery)
                Console.WriteLine(m);

            Console.WriteLine($"Count of marks >= 80: {topMarksQuery.Count()}");
        }

        internal class Student
        {
            public string Name { get; }
            public int Mark { get; }

            public Student(string name, int mark)
            {
                Name = name;
                Mark = mark;
            }
        }
    }
}