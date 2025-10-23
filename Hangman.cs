using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Hangman
    {
        public static readonly string[] Stages =
        {
            """
      
      
      
      
      
            =========
            """,
            """
                +
                |
                |
                |
                |
            =========
            """,
            """
                +---+
                |   
                |   
                |   
                |   
            =========
            """,
            """
                +---+
                |   O
                |   
                |   
                |   
            =========
            """,
            """
                +---+
                |   O
                |   |
                |   
                |   
            =========
            """,
            """
                +---+
                |   O
                |  /|
                |   
                |   
            =========
            """,
            """
                +---+
                |   O
                |  /|\
                |   
                |   
            =========
            """,
            """
                +---+
                |   O
                |  /|\
                |  / 
                |   
            =========
            """,
            """
                +---+
                |   O
                |  /|\
                |  / \
                |   
            =========
            """
        };


    }
}
