using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int NumberOfProject = int.Parse(Console.ReadLine());
            int TimeNeed = 3 * NumberOfProject;


            Console.WriteLine("The architect {0} will need {1} hours to complete {2} projects", name, TimeNeed, NumberOfProject);
        }
    }
}
