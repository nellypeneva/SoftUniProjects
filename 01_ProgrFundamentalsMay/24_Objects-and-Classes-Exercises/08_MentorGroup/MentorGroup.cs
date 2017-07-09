using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
namespace _08_MentorGroup
{
    class MentorGroup
    {
        static void Main()
        {

            SortedDictionary<string, Student> students = new SortedDictionary<string, Student>();

            ReadStudentsDates(students);

            ReadStudentsComments(students);

            PrintStudentsInfo(students);

        }

        public static void ReadStudentsDates(SortedDictionary<string, Student> students)
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of dates")
                {
                    break;
                }

                string[] input = line.Split(' ', ',');
                string name = input[0];

                List<DateTime> dates = input.Skip(1).Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();

                Student currentStudent = new Student(name); 

                if (!students.ContainsKey(name))
                {
                    students[name] = currentStudent;
                }

                students[name].Dates.AddRange(dates);
            }
        }

        public static void ReadStudentsComments(SortedDictionary<string, Student> students)
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of comments")
                {
                    break;
                }

                string[] input = line.Split('-');
                string name = input[0];
                string comment = input[1];

                if (!students.ContainsKey(name))
                {
                    continue;
                }

                students[name].Comments.Add(comment);
            }
        }

        public static void PrintStudentsInfo(SortedDictionary<string, Student> students)
        {

            foreach (var student in students)
            {
                Console.WriteLine(student.Value.Name);
                Console.WriteLine("Comments:");

                foreach (var comment in student.Value.Comments)
                {
                    Console.WriteLine("- {0}", comment);
                }

                Console.WriteLine("Dates attended:");
                var dates = student.Value.Dates.OrderBy(x => x).ToList();

                foreach (var date in dates)
                {
                    Console.WriteLine("-- {0}", date.ToString("dd/MM/yyyy"));
                }
            } 
        }
    }
}
