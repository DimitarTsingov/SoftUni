using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfBadMarks = int.Parse(Console.ReadLine());
            int currentCountOfBadMarks = 0;
            
            int countOfLessons = 0;
            string lastLesson = string.Empty;
            int sumOfMarks = 0;

            string lesson = Console.ReadLine();

            while (lesson != "Enough" )
            {
             
                int mark = int.Parse(Console.ReadLine());
                lastLesson = lesson;
                sumOfMarks += mark;

                if (mark < 4)
                {
                    countOfBadMarks--;
                }

                countOfLessons++;


                if (countOfBadMarks == 0)
                {
                    break;
                }

                lesson = Console.ReadLine();
            }

            double average = (double)sumOfMarks / countOfLessons;

            if (currentCountOfBadMarks == countOfBadMarks)
            {
                Console.WriteLine($"You need a break, {countOfBadMarks} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {countOfLessons}");
                Console.WriteLine($"Last problem: {lastLesson}");

            }

            
        }
    }
}
 