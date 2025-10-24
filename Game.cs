using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal static class Game
    {
        public static readonly string[] List = { "äpple", "tyvärr", "självklart", "citrus", "tvättkorg", "fönster", "telefon", "solrosfrö", "apelsinjuice" };

        private static HashSet<char> guessedLetters = new(); // keeps track of guessed letters

        private static int wrongGuesses = 0;

        public static string GetWord()
        {
            Random random = new();
            string word = List[random.Next(List.Length)];
            return word;
        }

        public static void Reset()
        {
            guessedLetters.Clear();
            wrongGuesses = 0;
        }

        public static bool CheckAndContinue(char letter, string word) //returns true if game should continue, false if game over/won
        {
            if (guessedLetters.Contains(letter))
            {
                Console.WriteLine($"\t\t\tDu har redan gissat på {letter}!");
                return true;
            }

            guessedLetters.Add(letter);

            Console.WriteLine($"\t\t\tDu gissade på {letter}");

            bool letterIsInWord = false; 


            string display = ""; //for building a string to display only guessed letters

            foreach (char c in word)
            {
                if (guessedLetters.Contains(c))
                {
                    display += c + " ";
                    if (c == letter) letterIsInWord = true;
                }
                else
                {
                    display += "_ ";
                }
            }

            if (!letterIsInWord)
            {
                wrongGuesses++;
            }

            Console.WriteLine(display);
            
            Console.WriteLine(Hangman.Stages[wrongGuesses]);

            if (!display.Contains('_') )
            {
                Console.WriteLine("\nDu klarade det! Snyggt jobbat!");
                return false;
            }
            
            if (wrongGuesses >= 8)
            {
                Console.WriteLine("\nTyvärr, du förlorade. Ordet var: " + word);
                return false;
            }

            return true;
        }

        public static void StartGame()
        {
            Console.Clear();
            string word = GetWord();
            Reset();

            bool inGame = true;

            while (inGame)
            {
                Console.Write("\n\t\t\tGissa en bokstav: ");

                if (!char.TryParse(Console.ReadLine(), out char userGuess))
                {
                    Console.WriteLine("\t\t\tSkriv endast en bokstav!");
                    continue;
                }

                inGame = CheckAndContinue(userGuess, word);

            }
        }
    }
}
