
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    public abstract class ScoringHand:Hand
    {
        // Attribute
        protected int score = 0;
        //Methods
        public abstract int GetScore();
    }
}
