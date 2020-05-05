using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowestCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            int counter = 0;

            char[] vowels = { '0', 'i', 'a', 'u', 'e' };

            for (int i = 0; i < word.Length; i++)
            {
                int currentSymbol = word[i];

                for (int j = 0; j < vowels.Length; j++)
                {
                    if (currentSymbol == vowels[j])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);

        }
    }
}
