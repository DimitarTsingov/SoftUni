using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 1;

            double balance = 0;

            
            while (counter <= n)
            {
                double sum = double.Parse(Console.ReadLine());

                if (sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {sum:f2}");
                counter++;
                balance += sum;

                
            }

            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
