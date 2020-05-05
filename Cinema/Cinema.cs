using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rowNumber = int.Parse(Console.ReadLine());
            int columnNumber = int.Parse(Console.ReadLine());

            double premiereProjection = 12.00;
            double normalProjection = 7.50;
            double discountProjection = 5.00;

            double totalPrice = 0.00;

            if (projection == "Premiere")
            {
                totalPrice = (rowNumber * columnNumber * 12.00);
                Console.WriteLine($"{totalPrice:f2}" + " leva");
            }
            else if (projection == "Normal")
            {
                totalPrice = (rowNumber * columnNumber) * 7.50;
                Console.WriteLine($"{totalPrice:f2}" + " leva");

            }
            else if (projection == "Discount")
            {
                totalPrice = (rowNumber * columnNumber) * 5.00;
                Console.WriteLine($"{totalPrice:f2}" + " leva");

            }


        }
    }
}
