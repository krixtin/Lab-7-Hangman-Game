using System.Xml.Linq;

namespace Lab_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

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
                    isRunning = true;
                    break;    
                case "2":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Fel. Välj 1 eller 2.");
                    break; //avslutar programmet, fixa?
            }
            Console.Clear();

            var game = new Game();

            string word = game.GetWord();

            while (isRunning)
            {
                Console.Write("\n\t\t\tGissa en bokstav: ");
                char userGuess = char.Parse(Console.ReadLine());

                game.CheckLetter(userGuess, word);

            }
            
            

        }
    }
}
