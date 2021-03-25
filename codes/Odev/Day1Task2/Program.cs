using System;
using System.Collections.Generic;

namespace Day1Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>();

            Course kurs1 = new Course
            {
                Id = 1,
                EducatorId = 1,
                Title = "C#",
                Price = 0,
                Description = "Sıfırdan C# Eğitimi"
            };

            Course kurs2 = new Course
            {
                Id = 2,
                EducatorId = 1,
                Title = "Java",
                Price = 0,
                Description = "Sıfırdan Java Eğitimi"
            };

            courses.Add(kurs1);
            courses.Add(kurs2);

            foreach (var kurs in courses)
            {
                Console.WriteLine(kurs.Description);
            }
        }
    }
}
