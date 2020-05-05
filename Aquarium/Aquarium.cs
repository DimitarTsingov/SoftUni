using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int Totalaquarium = lenght * weight * high;
            double TotalLiters = Totalaquarium * 0.001;
            double TotalPercent = percent * 0.01;

            double total = TotalLiters * (1 - TotalPercent);

            Console.WriteLine(Math.Round (total,3));
        }
    }
}
