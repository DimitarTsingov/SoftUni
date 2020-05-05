using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int volume = width * lenght * height;
            int sum = 0;


            string input = Console.ReadLine();

            while (input != "Done")
            {
                sum += int.Parse(input);

                if (volume <= sum)
                {
                    Console.WriteLine($"No more free space! You need {sum - volume} cubic meters more");
                }
                input = Console.ReadLine();
            }

            if (input == "Done")
            {
                int freeSpace = volume - sum;
                Console.WriteLine($"{freeSpace} cubic meters left.");
            }
        }
    }
}
