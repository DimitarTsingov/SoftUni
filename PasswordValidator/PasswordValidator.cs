using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isLenghtValid = false;
            bool areSymbolsValid = false;
            bool containsAtLeastTwiDigits = false;

            if (password.Length >= 6 && password.Length <= 10)
            {
                isLenghtValid = true;
            }

            int counter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    counter++;
                }

                if (!(password[i] >= 'A' && password[i] <= 'Z') || password[i] >= 'a' && password[i] <= 'z' ||
                    password[i] >= '0' && password[i] <= '9')
                {
                    areSymbolsValid = false;

                }
            }

            if (counter >= 2)
            {
                containsAtLeastTwiDigits = true;
            }

            if (!isLenghtValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!areSymbolsValid)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!containsAtLeastTwiDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isLenghtValid && areSymbolsValid & containsAtLeastTwiDigits)
            {
                Console.WriteLine("Password is valid");

            }
        }
    }
}
