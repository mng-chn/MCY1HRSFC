using System.Threading.Tasks;
using System;

namespace _16._10._24_Test_Marks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // === - Output a clear message with the student number (0-5) and the paper number (1-2) ===

            // Declare and initialise a 2D array for the test marks of Paper 1 and Paper 2
            int[,] marks = { { 34, 28, 12, 31, 18, 25 }, { 22, 15, 29, 36, 27, 19 } };
            int mark = 0;

            // Traverse the marks 2D array to output all the elements
            for (int row = 0; row < marks.GetLength(0); row++)
            {
                Console.WriteLine($"Paper {row + 1}");
                for (int col = 0; col < marks.GetLength(1); col++)
                {
                    // Output the test mark
                    Console.WriteLine($"Student {col}: {marks[row, col]}");
                }
                // Create a new empty line after all the marks of a paper has been output
                Console.WriteLine();
            }

            // === - Allow the user to replace a single test mark then output the updated 2D array ===
            int index = 0;
            Console.Write("Which mark would you like to change? (xy, paper number student number): ");
            index = Convert.ToInt16(Console.ReadLine());
            Console.Write("What mark would you like to change it to?: ");
            mark = Convert.ToInt16(Console.ReadLine());

            int[,] marks2 = marks;

            // Traverse the marks 2D array to find search element
            marks2[(index-10)/10,index%10] = mark;

            // Traverse the marks 2D array to output all the elements
            for (int row = 0; row < marks2.GetLength(0); row++)
            {
                Console.WriteLine($"Paper {row + 1}");
                for (int col = 0; col < marks2.GetLength(1); col++)
                {
                    // Output the test mark
                    Console.WriteLine($"Student {col}: {marks2[row, col]}");
                }
                // Create a new empty line after all the marks of a paper has been output
                Console.WriteLine();
            }

            // === -Allow the user to replace all of the test marks using another nested for loop ===
            /*Method 1: iterate through all items and replace them*/
            int[,] marks3 = marks;
            Console.Write("What mark would you like to replace all spaces to?: ");
            mark = Convert.ToInt16(Console.ReadLine());

            for (int row = 0; row < marks3.GetLength(0); row++)
            {
                Console.WriteLine($"Paper {row + 1}");
                for (int col = 0; col < marks3.GetLength(1); col++)
                {
                    // Output the test mark
                    marks3[row, col] = mark;
                    Console.WriteLine($"Student {col}: {marks3[row, col]}");
                }
                // Create a new empty line after all the marks of a paper has been output
                Console.WriteLine();
            }

            /*Method 2: select multiple spaces and replace selected items with same value*/
            /*int[,] marks4 = marks;

            Console.Write("Which mark would you like to change? (xy,xy,...): ");
            int[,] indexes = Console.ReadLine().Split(",");
            Console.Write("What mark would you like to replace all spaces to?: ");
            mark = Convert.ToInt16(Console.ReadLine());
            */

            /*Method 3: iterate through all items and replace them , each with a different value.*/
            int[,] marks5 = marks;

            for (int row = 0; row < marks5.GetLength(0); row++)
            {
                for (int col = 0; col < marks5.GetLength(1); col++)
                {
                    Console.Write("What mark would you like to replace this space to?: ");
                    mark = Convert.ToInt16(Console.ReadLine());

                    // Changes the test mark
                    marks5[row, col] = mark;

                    for (int row = 0; row < marks5.GetLength(0); row++)
                    {
                        Console.WriteLine($"Paper {row + 1}");
                        for (int col = 0; col < marks5.GetLength(1); col++)
                        {
                            // Output the test mark
                            Console.WriteLine($"Student {col}: {marks5[row, col]}");
                        }
                        // Create a new empty line after all the marks of a paper has been output
                        Console.WriteLine();
                    }

                }
                // Create a new empty line after all the marks of a paper has been output
                Console.WriteLine();
            }


            /* TASKS:
            - Output a clear message with the student number (0-5) and the paper number (1-2)
            - Allow the user to replace a single test mark then output the updated 2D array
            - Allow the user to replace all of the test marks using another nested for loop

            Challenge: Ask the user for the number of papers and students to submit marks for. 
            The program should create an empty 2D array and then ask the user for each mark.
            */

        }
    }
}
