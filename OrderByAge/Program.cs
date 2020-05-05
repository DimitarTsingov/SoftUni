using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] splittedInput = input
                    .Split(' ');

                string name = splittedInput[0];
                string id = splittedInput[1];
                int age = int.Parse(splittedInput[2]);

                Person person = new Person(name, id, age);

                people.Add(person);

                input = Console.ReadLine();
            }

            people = people
                .OrderBy(x => x.Age)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, people));
        }
    }
}
