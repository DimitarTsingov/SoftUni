using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfBook = Console.ReadLine();
            int capacityOfLibrary = int.Parse(Console.ReadLine());
            int counter = 0;
            
            while (capacityOfLibrary > counter)
            {
                string currentBook = Console.ReadLine();

                if (currentBook == nameOfBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }

                counter++;


                if (counter == capacityOfLibrary)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                }
                
            }
        }
    }
}
