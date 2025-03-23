using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._25_Card_Game_and_Polymorphism
{
    public class PokerHand:ScoringHand
    {
        //Attributes
        protected int score;
        //Constructor
        public PokerHand():base()
        {

        }
        //Methods
        public override int GetScore()
        {
            
            
            return score;
        }
    }
}
