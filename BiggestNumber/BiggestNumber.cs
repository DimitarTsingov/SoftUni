using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 1;
            int maxNumber = int.MinValue;

            while (counter <= n)
            {
                int currentNum = int.Parse(Console.ReadLine());
                
                if (currentNum > maxNumber)
                {
                    maxNumber = currentNum;
                }

                counter++;

            }

            Console.WriteLine($"Max number: {maxNumber}");

        }
    }
}
