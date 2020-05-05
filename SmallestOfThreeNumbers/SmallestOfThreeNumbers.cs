using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int firstResult = SmallerNumber(a, b);
            int smallestNumber = SmallerNumber(firstResult, c);

            Console.WriteLine(smallestNumber);
        }

        static int SmallerNumber(int firstNumber, int secondNumber)
        {
            if (firstNumber < secondNumber)
            {
                return firstNumber;
            }
            return secondNumber;

        }
    }
}
