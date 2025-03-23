namespace _18._10._24_Cinema_Tickets
{
    internal class Program
    {

        static char rowLetter(int rowNumber)
        {
            char rowLetter = (char)(rowNumber + 65);              // 65, 97
            return rowLetter;
        }

        static char letterRow(int rowLetter)
        {
            int rowNumber = (int)(rowLetter) - 65;              // 65, 97
            return rowNumber;
        }

        static void Main(string[] args)
        {
            int[,] seating =                                    // 0 represents empty, 1 adult, 2 child.
                {{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}};        // Array for cinema seats.

                                                                // Displays seating to user.
            Console.WriteLine("\t1\t2\t3\t4\t5\t6\t7\t8\t9\t10\t11\t12\t13\t14\t15\t16\t17\t18");

            for (int row = 0; row < seating.GetLength(0); row++)
            {
                Console.Write(rowLetter(row));                  // write subroutine that converts row index to letter.
                for (int col = 0; col < seating.GetLength(1); col++)
                {
                    Console.Write("\t{0}", seating[row,col]);
                }
                Console.WriteLine();
            }

                                                                // book a seat.
            Console.Write("Which seat would you like to book? (e.g. A1):");
            string seat = Console.ReadLine();                   // could write a validation function
            int seatrow = letterRow((int)seat.Remove(1));
            Console.WriteLine(seatrow);



            /*
            Seating plan: which seats are filled, which are empty.  

            10 rows of seats (A-J), 18 seats per row.
            If seat is booked: adult or child. 

            * Use a 2D array to represent the seating for a screen                                  ===
            * Display all of the seats to see which ones are booked or empty                        ===
            * Allow the user to book a specific seat if the seat is empty                           ===
            * Allow the user to book multiple seats next to each other in a row 
            * Output the total number of adult seats booked, child seats booked, and seats left 


            Extension: Develop the program for the cinema seating program which was set as an extension activity. Try using subroutines (covered next lesson) within the program. 
            */
        }
    }
}
