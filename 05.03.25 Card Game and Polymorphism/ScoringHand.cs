
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace _05._03._25_Card_Game_and_Polymorphism
{
    public abstract class ScoringHand:Hand
    {
        // Attribute
        protected int score =0;
        //Methods
        public abstract int GetScore();
    }
}
