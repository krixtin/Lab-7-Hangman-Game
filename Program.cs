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
                    isRunning = false; 
                    Console.WriteLine("Fel. Välj 1 eller 2.");
                    break; //avslutar programmet, fixa?
            }
            Console.Clear();

            

            string word = Game.GetWord();

            while (isRunning)
            {
                Console.Write("\n\t\t\tGissa en bokstav: ");
                char userGuess = char.Parse(Console.ReadLine());
                
                bool solved = Game.CheckLetter(userGuess, word);

                if (solved)
                {
                    Console.WriteLine("\nDu klarade det! Snyggt jobbat!");
                    isRunning = false;
                }

            }
            
            

        }
    }
}
