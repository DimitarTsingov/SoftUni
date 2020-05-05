using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 1;

            while (counter <= number)
            {
                Console.WriteLine(counter);
                counter = counter * 2 + 1;
            }

        }
    }
}
