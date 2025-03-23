using System;

namespace PCardGameIncomplete
{
  class Program
  {
    static void Main(string[] args)
    {
        bool isValid = false;
        string rankUser = string.Empty;
        string suitUser = string.Empty;
        string rankComputer = string.Empty;
        string suitComputer = string.Empty;
        int numberUser = 0;

        // "seeds" (initialises) the random number generator
        Random random = new Random();

        //selects a random number between 0 and 51,
        //adds one to it and assigns the result to number
        int numberComputer = random.Next(52) + 1;

        while (isValid == false)
        {
            Console.Write("Enter number 1-52: ");
            try
            {
                numberUser = Convert.ToInt32(Console.ReadLine());
                if (numberUser > 0 && numberUser < 53)
                {
                    isValid = true;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a number.");
            }
        }

        rankUser = GetRank(numberUser);
        suitUser = GetSuit(numberUser);
        rankComputer = GetRank(numberComputer);
        suitComputer = GetSuit(numberComputer);
          
        Console.WriteLine($"Your card is the {rankUser} of {suitUser}");
        Console.WriteLine($"Random card is the {rankComputer} of {suitComputer}");

        if (rankUser == rankComputer && suitUser == suitComputer)
        {
            Console.WriteLine("Your card is the same as the random card");
        }
        else
        {
            Console.WriteLine("Your card is not the same as the random card");
        }


        Console.ReadLine();
          
        // ??? complete this case statement for the other ranks
        static string GetRank(int number)
        {
            string rank = string.Empty;
            int ranknum = number % 13;
            switch (ranknum)
            {
                case 1:
                    rank = "Ace";
                    break;
                case 2:
                    rank = "Two";
                    break;
                case 3:
                    rank = "Three";
                    break;
                case 4:
                    rank = "Four";
                    break;
                case 5:
                    rank = "Five";
                    break;
                case 6:
                    rank = "Six";
                    break;
                case 7:
                    rank = "Seven";
                    break;
                case 8:
                    rank = "Eight";
                    break;
                case 9:
                    rank = "Nine";
                    break;
                case 10:
                    rank = "Ten";
                    break;
                case 11:
                    rank = "Jack";
                    break;
                case 12:
                    rank = "Queen";
                    break;
                case 13:
                    rank = "King";
                    break;
            }
            return rank;
        }

        // add if statements for the other suits
        static string GetSuit(int number)
        {
            string suit = string.Empty;
            int suitnum = number / 13;
            if (suitnum == 0)
            {
                suit = "Clubs";
            }
            else if (suitnum == 1)
            {
                suit = "Diamond";
            }
            else if (suitnum == 2)
            {
                suit = "Hearts";
            }
            else
            {
                suit = "Spades";
            }
            return suit;
        }
    }
  }
}