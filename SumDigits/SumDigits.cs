using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < numberAsString.Length; i++)
            {
                int digit = int.Parse(numberAsString[i].ToString());
                sum += digit;
            }

            Console.WriteLine(sum);
        }
    }
}
