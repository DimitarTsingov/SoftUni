using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstCoordinateX = double.Parse(Console.ReadLine());
            double firstCoordinateY = double.Parse(Console.ReadLine());

            double secondCoordinateX = double.Parse(Console.ReadLine());
            double secondCoordinateY = double.Parse(Console.ReadLine());

            double thirdCoordinateX = double.Parse(Console.ReadLine());
            double thirdCoordinateY = double.Parse(Console.ReadLine());

            bool isOnBorderByX = (thirdCoordinateX == firstCoordinateX || thirdCoordinateX == secondCoordinateX)
                && (thirdCoordinateY >= firstCoordinateY == thirdCoordinateY <= secondCoordinateY);

            bool isOnBorderByY = (thirdCoordinateY == firstCoordinateY || thirdCoordinateY == secondCoordinateY)
                && (thirdCoordinateX >= firstCoordinateX && thirdCoordinateX <= secondCoordinateX);

            if (isOnBorderByX || isOnBorderByY)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }


        }       
    }
}
