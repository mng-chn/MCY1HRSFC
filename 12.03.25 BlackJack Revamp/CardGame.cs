using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace Game
{
    public abstract class CardGame
    {
        //Attributes
        protected string title;
        protected string description;
        protected Card[] deck;
        protected int players;
        protected int computers;

        //Methods
        public abstract string Display_Title();
        public abstract string Display_Description();
        //public abstract string ();
        public abstract string Name();
        public abstract string Id();
        public abstract string TypeCode();
        //public abstract ;
    }
}
