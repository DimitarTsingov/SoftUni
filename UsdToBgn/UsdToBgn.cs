using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsdToBgn
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());

            double result = usd * 1.79549;

            Console.WriteLine($"{result:f2}");


        }
    }
}
