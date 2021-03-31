using System;
using System.Collections.Generic;

namespace Day4Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(145, "Ali Atakay");
            students.Add(178, "Ahmet Demir");
            students.Add(221, "Zeynep Deniz");

            foreach (var student in students)
            {
                Console.WriteLine("Student Number: " + student.Key);
                Console.WriteLine("Student Name: " + student.Value);
            }

            MyDictionary<int, string> teachers = new MyDictionary<int, string>();

            teachers.Add(1, "Ali Atakay");
            teachers.Add(2, "Ahmet Demir");
            teachers.Add(3, "Zeynep Deniz");

            Console.WriteLine(teachers.Length);

        }
    }
}
