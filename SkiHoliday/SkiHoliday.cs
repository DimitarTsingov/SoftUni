using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayInHotel = int.Parse(Console.ReadLine());
            string roomInHotel = Console.ReadLine();
            string feedback = Console.ReadLine();

            double priceRoomForOnePerson = 18.00;
            double priceApartment = 25.00;
            double pricePresidentApartment = 35;
            double finalPrice = 0.00;
            int nights = dayInHotel - 1;
            double pricePerNight = 0;

            if (roomInHotel == "room for one person")
            {
                if (dayInHotel < 10 || (dayInHotel >=10 && dayInHotel <=15) || dayInHotel > 15)
                {
                    finalPrice = dayInHotel * priceRoomForOnePerson;

                    if (feedback == "positive")
                    {
                        finalPrice *= 0.25;
                        Console.WriteLine($"{finalPrice:f2}");
                    }
                    if (feedback == "negative")
                    {
                        finalPrice /= 0.1;
                        Console.WriteLine($"{finalPrice:f2}");

                    }
                }
            }

            if (roomInHotel == "apartment")
            {
                if (dayInHotel < 10)
                {
                    finalPrice = (dayInHotel * priceApartment) * 0.3;

                    if (feedback == "positive")
                    {
                        finalPrice *= 0.25;
                        Console.WriteLine($"{finalPrice:f2}");

                    }
                    if (feedback == "negative")
                    {
                        finalPrice /= 0.1;
                        Console.WriteLine($"{finalPrice:f2}");

                    }
                }
                if (dayInHotel >= 10 && dayInHotel <= 15)
                {
                    finalPrice = (dayInHotel * priceApartment) * 0.35;

                    if (feedback == "positive")
                    {
                        finalPrice *= 0.25;
                        Console.WriteLine($"{finalPrice:f2}");

                    }
                    if (feedback == "negative")
                    {
                        finalPrice /= 0.25;
                        Console.WriteLine($"{finalPrice:f2}");

                    }
                }
                if (dayInHotel > 15)
                {
                    finalPrice = (dayInHotel * priceApartment) * 0.5;
                    Console.WriteLine($"{finalPrice:f2}");

                }
            }
            if (roomInHotel == "president apartment")
            {
                if (dayInHotel <10)
                {
                    finalPrice = (dayInHotel * pricePresidentApartment) * 0.1;
                    Console.WriteLine($"{finalPrice:f2}");

                }
                if (dayInHotel == 10 && dayInHotel <= 15 )
                {
                    finalPrice = (dayInHotel * pricePresidentApartment) * 0.15;
                    Console.WriteLine($"{finalPrice:f2}");

                }
                if (dayInHotel > 15)
                {
                    finalPrice = (dayInHotel * pricePresidentApartment) * 0.2;
                    Console.WriteLine($"{finalPrice:f2}");

                }
            }

            
        }
    }
}
