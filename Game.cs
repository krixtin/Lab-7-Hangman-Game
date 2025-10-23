using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Game
    {
        public readonly string[] List = { "äpple", "tyvärr", "självklart", "citrus", "tvättkorg", "fönster", "telefon", "solrosfrö", "apelsinjuice" };

        public string GetWord()
        {
            Random random = new();
            string word = List[random.Next(List.Length)];
            return word;
        }

        private HashSet<char> guessedLetters = new(); // keeps track of guessed letters

        public void CheckLetter(char letter, string word)
        {
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
                    display += "_ ";
                }
            }

            //if (display.Contains('_'))
            //{
                
            //}
            //else
            //{

            //}

                Console.WriteLine(display);
        }


    }
}
