using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());

            for (int firstNum = 1; firstNum <= 9; firstNum++)
            {
                for (int secondNum = 1; secondNum <= 9; secondNum++)
                {
                    for (int thirdNum = 1; thirdNum <= 9; thirdNum++)
                    {
                        for (int fourthNum = 1; fourthNum <= 9; fourthNum++)
                        {
                            for (int fifthNum = 1; fifthNum <= 9; fifthNum++)
                            {
                                for (int sixthNum = 1; sixthNum <= 9; sixthNum++)
                                {
                                    int product = firstNum * secondNum * thirdNum * fourthNum * fifthNum * sixthNum;

                                    if (product == magicNumber)
                                    {
                                        Console.Write($"{firstNum}{secondNum}{thirdNum}{fourthNum}{fifthNum}{sixthNum} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
