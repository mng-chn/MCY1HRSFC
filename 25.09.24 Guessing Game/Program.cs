using System;

namespace HigherLower
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 101);
            int guess = 0;
            int guesses = 0;
            bool correct = false;
            Console.WriteLine("Guess a number between 1 and 100");
            while (correct == false)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > number)
                {
                    Console.WriteLine("Lower");
                    guesses++;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                    guesses++;
                }
                else
                {
                    Console.WriteLine("Correct");
                    correct = true;
                    guesses++;
                }
            }
            Console.WriteLine(guesses);
            Console.WriteLine("Play again?");
            string playAgain = Console.ReadLine();
            if (playAgain == "yes")
            {
                Main(args);
            }
        }
    }
}