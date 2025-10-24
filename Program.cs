using System.Xml.Linq;

namespace Lab_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("""
                +---+
                |   O
                |  /|\         Välkommen till Hänga gubbe-spelet!
                |  / \
                |              1. Nytt spel
                =========      2. Avsluta
                """);

                string? userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Game.StartGame();
                        Console.WriteLine("\nTryck på valfri tangent för att återgå till menyn.");
                        Console.ReadKey();
                        break;
                    case "2":
                        isRunning = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\n\n\t\tOgiltigt val. Tryck på valfri tangent för att fortsätta.");
                        Console.ReadKey();
                        break;
                }

                Console.Clear();
            }
        }
    }
}
