using System;
using System.Collections.Generic;
using System.Linq; 

namespace _04_AverageGrades
{
    public class AverageGrades
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Student[] students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                students[i] = ReadStudent();
            }

            var studentsSelection = students.Where(x => x.AverageGrade >= 5).OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade);
            
            foreach (Student student in studentsSelection)
            {
                Console.WriteLine("{0} -> {1:f2}", student.Name, student.AverageGrade);
            }
        }

        public static Student ReadStudent()
        {
            string[] input = Console.ReadLine().Split(' ');
            List<double> grades = input.Skip(1).Select(double.Parse).ToList();

            return new Student { Name = input[0], Grades = grades }; 
        } 
    }
}
