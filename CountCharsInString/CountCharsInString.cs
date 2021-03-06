﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCharsInString
{
    class CountCharsInString
    {
        static void Main(string[] args)
        {
            string someText = Console.ReadLine();

            Dictionary<char, int> lettersCount = new Dictionary<char, int>();

            for (int i = 0; i < someText.Length; i++)
            {
                char letter = someText[i];

                if (letter != ' ')
                {
                    if (!lettersCount.ContainsKey(letter))
                    {
                        lettersCount[letter] = 1;
                    }

                    else
                    {
                        lettersCount[letter]++;
                    }
                }
                
            }

            foreach (var kvp in lettersCount)
            {
                char key = kvp.Key;
                int value = kvp.Value;

                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
