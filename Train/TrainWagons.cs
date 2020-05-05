using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToList();

            int capacity = int.Parse(Console.ReadLine());

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] splittedInput = input
                    .Split(' ');

                if (splittedInput.Length == 1)
                {
                    int passengers = int.Parse(splittedInput[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= capacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
                else
                {
                    int passengers = int.Parse(splittedInput[1]);

                    wagons.Add(passengers);
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
            
        }
    }
}
