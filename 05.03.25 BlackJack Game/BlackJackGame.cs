using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace BlackJackGameNameSpace
{
    public class BlackJackGame
    {
        //Attributes

        //Set-up settings (include in constructor)
        int players = 1; //players for now will be 1.
        private Pack pack;
        BlackJackHand player_hand;
        private BlackJackHand computer_hand;
        private double funds; // betting will be omitted for now
        private int chips;
        private int bet;
        private int[] scoreboard;

        //In-game settings (can be modified during play)

        
        //Constructor
        public BlackJackGame() 
        {
            pack = new Pack(52);
            player_hand = new BlackJackHand();
            computer_hand = new BlackJackHand();
            scoreboard = new int[players+2];
            pack.Shuffle();
        }
        //Methods
        public void Play_All()
        {
            //Wager();
            Deal();
            Play();
            Display_Winner(scoreboard);
        }
        public void Buy_Chips()
        {
            
        }
        public void Wager(int chips)
        {
            if (bet >= chips)
            {
                bet = chips;
            }
            else { Console.WriteLine("Not enough chips to make bet."); }
        }
        public void Deal() //face up face down will be ignored for now as game is P1 v COM.
        {
           
            for (int i = 0; i < 2; i++)
            {
                player_hand.AddCard(pack.DealCard());
            }
           
            for (int i = 0; i < 2; i++)
            {
                computer_hand.AddCard(pack.DealCard());
            }
        }
        public void Play()
        {
            int player_score = PlayerTurn();
            Console.WriteLine("waiting for computer...");
            int computer_score = ComputerTurn();
            Console.WriteLine("calculating winner...");

            scoreboard[0] = computer_score; scoreboard[1] = player_score;
            scoreboard = Calculate_Winner(scoreboard);
        }

        private static int[] Calculate_Winner(int[] ints) // Tested all outcomes, all outcomes are correct.
        {
            int winner = -2;
            //Is player in?
            if (ints[1] > 21)
            { ints[1] = -1; }
            //Is computer in?
            if (ints[0] > 21)
            { ints[0] = -1; }

            if (ints[1] > ints[0])
            {
                winner = 1; //player wins
            }
            else if (ints[1] < ints[0])
            {
                winner = 0; //dealer wins
            }
            else
            {
                winner = -1; //draw
            }

            ints[2] = winner;
            //Console.WriteLine("end");
            return ints;
        }

        public void Display_Winner(int[] game_values)
        {
            switch (game_values[2])
            {
                case 0: Console.WriteLine("Dealer wins."); break;
                case 1: Console.WriteLine("Player wins!"); break;
                case -1: Console.WriteLine("Draw."); break;
            }
        }
        private int PlayerTurn()
        {
            int score = player_hand.GetScore();
            bool players_turn = true;
            string players_choice;
            while (score < 21 && players_turn)
            {
                Display_Score(score, player_hand, "Player");

                players_choice = Console.ReadLine().ToUpper();
                if (players_choice == "HIT")
                {
                    Hit(player_hand);
                    score = player_hand.GetScore();
                    Console.WriteLine(score);
                }
                else if (players_choice == "STAND")
                {
                    score = player_hand.GetScore();
                    Console.WriteLine($"\nFINAL SCORE: {score}\n");
                    players_turn = false;
                }
                else
                {
                    Console.WriteLine("Please select a valid option.");
                }

                // if the user select stand return
                // if the user select hit add new card, recalculate score (bust), loop
                score = player_hand.GetScore();

            }
            if (score == 21) { Blackjack();  }
            else if (score > 21) { Bust(); }
            Console.WriteLine("player turn finished");
            return score;
        }

        private void Display_Score(int score, BlackJackHand hand, string user)
        {
            // display the cards and score of the hand
            Console.WriteLine($"\nCARDS ========\n");
            for (int i = 0; i < hand.Size; i++)
            {
                Console.WriteLine(hand[i].GetName());
            }
            Console.WriteLine($"\n==============\n");

            Console.WriteLine($"SCORE: {score}");

            // ask the user hit or stand
            Console.WriteLine($"\n==============\n");
            if (user == "Player")
            { Console.WriteLine($"Would you like to [Hit] or [Stand]?"); }
        }

        private int ComputerTurn()
        {
            int score = computer_hand.GetScore();
            bool computers_turn = true;
            while (score < 21 && computers_turn)
            {
                score = computer_hand.GetScore();
                Display_Score(score, computer_hand, "Computer");
                
                if (score < 17)
                {
                    Hit(computer_hand);
                    score = computer_hand.GetScore();
                    Console.WriteLine(score);
                }
                else if (score >= 17)
                {
                    score = computer_hand.GetScore();
                    Console.WriteLine($"\nFINAL SCORE: {score}\n");
                    computers_turn = false;
                }
                else
                {
                    Console.WriteLine("Please select a valid option.");
                }

                // if the user select stand return
                // if the user select hit add new card, recalculate score (bust), loop
                score = computer_hand.GetScore();

            }
            if (score == 21) { Blackjack(); }
            else if (score > 21) { Bust(); }
            Console.WriteLine("computer turn finished");
            return score;

        }
        public void Payout(){}
        public void Blackjack(){}
        public void Stand() { }
        public void Hit(BlackJackHand hand)
        {
            hand.AddCard(pack.DealCard());
        }
        public void Double_Down() { }
        public void Split() { }
        public void Surrender() { }
        public void Bust() { Console.WriteLine("Bust."); }
    }
}
