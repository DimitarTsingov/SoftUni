using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coordinates = ParseInput();

            Point topLeft = new Point(coordinates[0], coordinates[1]);
            Point bottomRight = new Point(coordinates[2], coordinates[3]);

            Rectangle rectangle = new Rectangle(topLeft, bottomRight);

            int numberOfPoints = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPoints; i++)
            {
                int[] point = ParseInput();
                Point pointToCheck = new Point(point[0], point[1]);

                Console.WriteLine(rectangle.Contains(pointToCheck));
            }
        }

        private static int[] ParseInput()
        {
            return Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
        }
    }
}
