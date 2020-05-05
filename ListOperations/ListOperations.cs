using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
    .Split(' ')
    .Select(x => int.Parse(x))
    .ToList();

            string input;

            while ((input = Console.ReadLine()) != "End") 
            {
                string[] splittedInput = input
                    .Split(' ');

                string command = splittedInput[0];

                switch (command)
                {
                    case "Add":

                        int number = int.Parse(splittedInput[1]);

                        numbers.Add(number);

                        break;

                    case "Insert":

                        number = int.Parse(splittedInput[1]);

                        int index = int.Parse(splittedInput[2]);

                        if (index < 0 || index >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }


                        numbers.Insert(index, number);

                        break;

                    case "Remove":

                        index = int.Parse(splittedInput[1]);

                        if (index < 0 || index >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }

                        numbers.RemoveAt(index);

                        break;

                    case "Shift":

                        string direction = splittedInput[1];
                        int count = int.Parse(splittedInput[2]);

                        if (direction == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Add(numbers[0]);
                                numbers.RemoveAt(0);
                            }

                        }

                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Insert(0, numbers[numbers.Count - 1]);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }

                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
