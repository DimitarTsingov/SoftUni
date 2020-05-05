using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string metricUnit = Console.ReadLine();
            string metricUnitExit = Console.ReadLine();

            if (metricUnit == "m" && metricUnitExit == "mm") {
                Console.WriteLine($"{number * 1000:f3}");
            } else if (metricUnit == "m" && metricUnitExit == "cm")
            {
                Console.WriteLine($"{number * 100:f3}");
            } else if (metricUnit == "mm" && metricUnitExit == "m")
            {
                Console.WriteLine($"{number / 1000:f3}");
            } else if (metricUnit == "mm" && metricUnitExit == "cm")

            {
                Console.WriteLine($"{number / 10:f3)}");
            } else if (metricUnit == "cm" && metricUnitExit == "m")
            {
                Console.WriteLine($"{number / 100:f3}");
            }else if (metricUnit == "cm" && metricUnitExit == "mm")
            {
                Console.WriteLine($"{number * 10:f3}");
            }

        }
    }
}
