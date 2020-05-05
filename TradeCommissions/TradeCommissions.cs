using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double comission = 0;

            if (city == "Sofia")
            {
                if (sales <= 500)
                {
                    comission = sales * 0.05;
                    Console.WriteLine($"{comission:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.07;
                    Console.WriteLine($"{comission:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.08;
                    Console.WriteLine($"{comission:f2}");
                }
                else if (sales > 10000)
                {
                    comission = sales * 1.2;
                    Console.WriteLine($"{comission:f2}");
                }
            }
            if (city == "Varna")
            {
                if (sales <= 500)
                {
                    comission = sales * 0.45;
                    Console.WriteLine($"{comission:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.75;
                    Console.WriteLine($"{comission:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 1;
                    Console.WriteLine($"{comission:f2}");
                }
                else if (sales > 10000)
                {
                    comission = sales * 1.3;
                    Console.WriteLine($"{comission:f2}");
                }
            }
            if (city == "Plovdiv")
            {
                if (sales <= 500)
                {
                    comission = sales * 0.55;
                    Console.WriteLine($"{comission:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.08;
                    Console.WriteLine($"{comission:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 1.2;
                    Console.WriteLine($"{comission:f2}");
                }
                else if (sales > 10000)
                {
                    comission = sales * 1.45;
                    Console.WriteLine($"{comission:f2}");
                }
            }
            else 
            {
                Console.WriteLine("error");
            }
        }
    }
}
