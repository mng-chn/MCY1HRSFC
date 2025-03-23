using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._25_Card_Game_and_Polymorphism
{
    public class BlackJackHand : ScoringHand
    {
        protected int aces;
        //Constructor
        public BlackJackHand() { }
        //Methods
        public override int GetScore()
        {
            foreach (var card in cards)
            {
                if (card.GetRank() == 1)
                {
                    score += 11;
                    aces++;
                }
                else if (card.GetRank() < 10)
                {
                    score += 10;
                }
                else
                {
                    score += card.GetRank();
                }
            }
            if (score > 21 && aces > 0)
            {
                score -= 10;
                aces--;
            }
            return score;
        }
    }
}
