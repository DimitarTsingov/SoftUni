using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
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
             
            while ((input = Console.ReadLine()) != "end")
            {
                string[] splittedInput = input
                    .Split(' ');

                string command = splittedInput[0];
                int number = int.Parse(splittedInput[1]);

                if (command =="Delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (number == numbers[i])
                        {
                            numbers.Remove(number);
                            i--;
                        }
                    }
                }

                else if (command == "Insert")
                {
                    int position = int.Parse(splittedInput[2]);

                    numbers.Insert(position, number);
                }
            
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
