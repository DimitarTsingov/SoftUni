using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {

            int studentsCounts = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < studentsCounts; i++)
            {
                string[] studentArgs = Console.ReadLine()
                    .Split(' ');

                string firstName = studentArgs[0];
                string lastName = studentArgs[1];
                double grade = double.Parse(studentArgs[2]);

                Student student = new Student(firstName, lastName, grade);

                students.Add(student);

            }

            List<Student> sortedStudents = students
                    .OrderByDescending(x => x.Grade)
                    .ToList();

            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
