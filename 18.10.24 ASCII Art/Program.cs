﻿namespace _18._10._24_ASCII_Art
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialise a 2D array for the ASCII art
            char[,] asciiArtArray = { { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                { ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ' },
                { ' ', ' ', ' ', '*', '*', '*', ' ', ' ', ' ', ' ', '*', '*', '*', ' ', ' ', ' ' },
                { ' ', ' ', ' ', '*', '*', '*', ' ', ' ', ' ', ' ', '*', '*', '*', ' ', ' ', ' ' },
                { ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ' },
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                { '*', '*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*', '*' },
                { ' ', '*', '*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*', '*', ' ' },
                { ' ', ' ', '*', '*', '*', ' ', ' ', ' ', ' ', ' ', ' ', '*', '*', '*', ' ', ' ' },
                { ' ', ' ', ' ', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', ' ', ' ', ' ' },
                { ' ', ' ', ' ', ' ', ' ', ' ', '*', '*', '*', '*', ' ', ' ', ' ', ' ', ' ', ' ' } };


            // Traverse the ascii art 2D array and output all the elements
            for (int row = 0; row < asciiArtArray.GetLength(0); row++)
            {
                for (int col = 0; col < asciiArtArray.GetLength(1); col++)
                {
                    Console.Write(asciiArtArray[row,col]);
                }
                Console.WriteLine();
            }


            /* TASKS:
            1. Create an outer for loop which iterates through every row
            2. Create a nested inner for loop which iterates through every column
            3. Output all elements of the 2D array on a single line. Hint: use Console.Write()
            4. Output an empty new line after each row. Hint: use Console.WriteLine() 
            5. Create your own ASCII Art!
            */
        }
    }
}
