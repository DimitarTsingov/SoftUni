using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = people / capacity;
            int extraCourse = people % capacity;

            if (extraCourse != 0)
            {
                courses++;
            }

            Console.WriteLine(DateTime.Now);
        }
    }
}
