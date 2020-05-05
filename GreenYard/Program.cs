using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenYard
{
    class Program
    {
        static void Main(string[] args)
        {
            int yard = int.Parse(Console.ReadLine());
            double price = yard * 7.61;
            double discount = Math.Round (0.18 * price, 2);
            double FinalPrice = Math.Round (price - discount,2);

            Console.WriteLine("The final price is {0} lv.", FinalPrice);
            Console.WriteLine("The discount is {0} lv.", discount);


        }
    }
}
