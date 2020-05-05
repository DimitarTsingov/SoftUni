using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WagonCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonCount = int.Parse(Console.ReadLine());

            int[] train = new int[wagonCount];

            int sum = 0;
            
            for (int i = 0; i < wagonCount; i++)
            {
                int peopleInWagon = int.Parse(Console.ReadLine());

                train[i] = peopleInWagon;
                sum += peopleInWagon;
            }

            Console.WriteLine(String.Join(" ", train));
            Console.WriteLine(sum);

        }
    }
}
