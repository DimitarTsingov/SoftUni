using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameWar
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int sum = 0;

            while (text != "STOP")
            {
                for (int i = 0; i < text.Length; i++)
                {
                    sum += text[i];
                }
            }

           
        }
    }
}
