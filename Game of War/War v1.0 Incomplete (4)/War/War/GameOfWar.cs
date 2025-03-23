using System;
using CardClasses;

namespace War
{   
    //NB uses System and CardClasses
    public class GameOfWar 
    {
        private Pack pack;
        private Hand p1Hand, p2Hand;

        public GameOfWar()
        {
            //!!!!
            //create the pack and hands
            //!!!!
            //shuffle the pack
            //!!!!
        }

        public void Deal()
        {
            while (!pack.IsEmpty())
            {
                p1Hand.AddCard(pack.DealCard());
                // do the same for p2Hand
                //!!!!
            }
        }

        public void Play()
        {
            Hand p1CardsInPlay = new Hand();
            Hand p2CardsInPlay = new Hand();
            Random random = new Random();
            while //!!!! both player's have some cards left in their hands
            {
                do
                {
                    p1CardsInPlay.AddCard(p1Hand.RemoveFirstCard());
                    p2CardsInPlay.AddCard(p2Hand.RemoveFirstCard());
                    Console.WriteLine(p1CardsInPlay.Last().GetName() + " " + p2CardsInPlay.Last().GetName());
                } while //!!!! the last pair of cards put down are the same rank

                if //!!!! Player1's card is higher than Player2's card
                {
                    Console.WriteLine("Player 1 wins");
                    while (!p1CardsInPlay.IsEmpty())
                    {
                        p1Hand.AddCard(p1CardsInPlay.RemoveFirstCard());
                        p1Hand.AddCard(p2CardsInPlay.RemoveFirstCard());
                    }
                }
                else
                {
                    //!!!! do the same but for Player2
                    //!!!!
                    //!!!!
                    //!!!!
                    //!!!!
                }
                Console.WriteLine("Player 1 has " + p1Hand.Size + " cards");
                Console.WriteLine("Player 2 has " + p2Hand.Size + " cards");
            }
        }

    }
}
