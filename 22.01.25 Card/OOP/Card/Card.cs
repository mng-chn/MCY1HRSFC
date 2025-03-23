using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    public class Card
    {
        private int rank;
        private int suit;

        public Card(int r, int s)
        {
            rank = r;
            suit = s;
        }
        public int GetRank()
        {
            return rank+1;
        }
        public int GetSuit()
        {
            return suit+1;
        }
        public int GetScore()
        {
            return (rank - 1) * 4 + 1 + suit;
        }
        public string GetSuitAsString()
        {
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades"};
            return suits[suit];
        }
        public string GetRankAsString()
        {
            string[] ranks = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
            return ranks[rank];
        }
        public string GetName()
        {
            string name = $"{GetRankAsString()} of {GetSuitAsString()}";
            return name;
        }
    }
}
