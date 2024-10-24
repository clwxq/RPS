using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace RPS
{
    internal class Kodik
    {
        Random Rand = new Random();
        int ai { get; set; }
        int x { get; set; }
        int y { get; set; }

        public void Single ()
        {
            string choice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("Player 1")
            .PageSize(10)
            .AddChoices(new[] {
           "dnd dice","grandma’s kitchen cloth", "double katana"
            }));
            switch (choice)
            {
                case "dnd dice":
                    x = 1;
                    break;
                case "grandma’s kitchen cloth":
                    x = 2;
                    break;
                case "double katana":
                    x = 3;
                    break;
            }
            ai = Rand.Next(1, 4);

            if (x == ai)
            {
                Console.WriteLine("Draw");
            }
            else if (x == 1 && ai == 3 || x == 2 && ai == 1 || x == 3 && ai == 2)
            {
                Console.WriteLine("Player1 W");
            }
            else
            {
                Console.WriteLine("AI W");
            }
        }
        public void Multi ()
        {
            string choice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("Player 1:")
            .PageSize(10)
            .AddChoices(new[] {
            "dnd dice","grandma’s kitchen cloth", "double katana"
            }));
            switch (choice)
            {
                case "dnd dice":
                    y = 1;
                    break;
                case "grandma’s kitchen cloth":
                    y = 2;
                    break;
                case "double katana":
                    y = 3;
                    break;
            }

            choice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("Player 2:")
            .PageSize(10)
            .AddChoices(new[] {
            "dnd dice","grandma’s kitchen cloth", "double katana"
            }));
            switch (choice)
            {
                case "dnd dice":
                    y = 1;
                    break;
                case "grandma’s kitchen cloth":
                    y = 2;
                    break;
                case "double katana":
                    y = 3;
                    break;
            }

            if (x == y)
            {
                Console.WriteLine("Draw");
            }
            else if (x == 1 && y == 3 || x == 2 && y == 1 || x == 3 && y == 2)
            {
                Console.WriteLine("Player1 W");
            }
            else
            {
                Console.WriteLine("Player2 W");
            }
        }
    }
}
