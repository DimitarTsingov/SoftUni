using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberTable = int.Parse(Console.ReadLine());
            double lenghtTable = double.Parse(Console.ReadLine());
            double widthTable = double.Parse(Console.ReadLine());

            int rectangularCover = 7;
            int checkeredCover = 9;
            double usd = 1.85;

            double coverArea = numberTable * (lenghtTable + 2 * 0.30) * (widthTable + 2 * 0.30);

            double checkeredArea = numberTable * (lenghtTable / 2) * (lenghtTable / 2);

            double priceUsd = coverArea * rectangularCover + checkeredArea * checkeredCover;

            double priceBgn = priceUsd * usd;

            Console.WriteLine($"{priceUsd:f2}"+ " USD");
            Console.WriteLine($"{priceBgn:f2}"+ " BGN");

        }
    }
}
