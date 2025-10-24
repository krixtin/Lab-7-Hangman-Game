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

        public static bool WordIsComplete;

        public static string GetWord()
        {
            Random random = new();
            string word = List[random.Next(List.Length)];
            return word;
        }

        private static HashSet<char> guessedLetters = new(); // keeps track of guessed letters

        public static bool CheckLetter(char letter, string word)
        {
            //int tries = 8;
            //while (tries > 0)
            //{

            //}
            guessedLetters.Add(letter);
            Console.WriteLine($"\t\t\tDu gissade på {letter}");

            string display = ""; // building a string to display only guessed letters

            foreach (char c in word)
            {
                if (guessedLetters.Contains(c))
                {
                    display += c + " ";
                }
                else
                {
                    //tries--;
                    display += "_ ";
                }
            }

            Console.WriteLine(display);

            
            
            
            if (!display.Contains('_') )//&& tries < 9)
            {
                WordIsComplete = true;
            }

            return WordIsComplete;

        }


    }
}
