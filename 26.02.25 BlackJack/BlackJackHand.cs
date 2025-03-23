using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._25_BlackJack
{
    internal class BlackJackHand
    {
        protected int score;
        public int GetScore(Hand hand)
        {
            foreach (card in hand)
            {
                if (card.GetRank() > 10)
                {
                    score += 10; 
                }
                else if (card.GetRank() > 1)
                {
                    score += card.GetRank();
                }
                if (score + 11 > 21)
                {
                    score += 1;
                }
                else
                {
                    score += 11;
                }
            }
            return score;
        }
    }
}
