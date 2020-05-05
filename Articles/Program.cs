using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleArgs = Console.ReadLine()
                .Split(',');

            string title = articleArgs[0];
            string content = articleArgs[1];
            string author = articleArgs[2];

            Article article = new Article(title, content, author);

            int countOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfCommands; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(':');

                string command = commandArgs[0];
                string value = commandArgs[1];

                if (command == "Edit")
                {
                    string currentContent = commandArgs[1];
                    article.Edit(currentContent);
                }

                else if (command == "ChangeAuthor")
                {
                    string currentAuthor = commandArgs[1];
                    article.ChangeAuthor(currentAuthor);
                }

                else if (command == "Rename")
                {
                    string currentTitle = commandArgs[1];
                    article.Rename(currentTitle);
                }


            }

            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");

        }
    }
}
