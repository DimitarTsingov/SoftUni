using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes >= 60)
            {
                minutes -= 60;
                hour++;
            }
            if (hour > 23)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{minutes:D2}");


        }
    }
}
