using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceExcursion = double.Parse(Console.ReadLine());
            int puzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double puzlePrice = 2.60;
            double dollPrice = 3;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2;

            double totalSum = puzles * puzlePrice + dolls * dollPrice + bears * bearPrice + minions * minionPrice + trucks * truckPrice;
            double numberOfToys = puzles + dolls + bears + minions + trucks;
            double finalPrice = totalSum * 0.75;

            if (numberOfToys > 50)
            {
                totalSum = finalPrice;
            }

            double rent = totalSum * 0.10;
            double income = totalSum - rent;

            double leftMoney = income - priceExcursion;
            double needMoney = priceExcursion - income;

            if (income > priceExcursion)
            {
                Console.WriteLine("Yes! " + $"{leftMoney:f2}" + " lv left.");
            } else if (income < priceExcursion)
            {
                Console.WriteLine("Not enough money! " + $"{needMoney:f2}" + " lv needed.");
            }

        }
    }
}
