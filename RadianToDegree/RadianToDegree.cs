﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadianToDegree
{
    class Program
    {
        static void Main(string[] args)
        {
            double radian = double.Parse(Console.ReadLine());
            double degree = radian * (180 / Math.PI);

            Console.WriteLine(Math.Round(degree));
        }
    }
}
