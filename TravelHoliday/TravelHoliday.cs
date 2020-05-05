using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                while (savedMoney < budget)
                {
                    double money = double.Parse(Console.ReadLine());
                    savedMoney += money;
                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();

            }

        }
    }
}
