using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInRectangle
{
    public class Point
    {
        public int CoordinateX { get; set; }

        public int CoordinateY { get; set; }

        public Point(int coordinateX, int coordinateY)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }
    }
}
