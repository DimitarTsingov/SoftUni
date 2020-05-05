using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            if (name == "dog")
            {
                Console.WriteLine("mammal");
            } else if (name == "crocodile" || name == "turtoise" || name == "snake" )
            {
                Console.WriteLine("reptile");
            } else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
