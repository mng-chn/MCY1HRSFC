using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace BlackJackGameNameSpace
{
    public class BlackJackHand : ScoringHand
    {
        protected int aces;
        //Constructor
        public BlackJackHand() { }
        //Methods
        public override int GetScore()
        {
            score = 0;
            foreach (var card in cards)
            {
                if (card.GetRank() == 1)
                {
                    //Console.WriteLine("plus 11");
                    score += 11;
                    aces++;
                }
                else if (card.GetRank() > 10)
                {
                    //Console.WriteLine("plus 10");
                    score += 10;
                }
                else
                {
                    //Console.WriteLine("plus {0}", card.GetRank());
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
