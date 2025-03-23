using CardClasses;
using BlackJackGameNameSpace;

namespace _05._03._25_BlackJack_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Game of Blackjack: 
             
             Scoring: BlackJackHand class, GetScore()
             Layout: player (<7) vs. dealer (1)
             Pack: 52 cards
             Decks: 6-deck (or 8-deck)
             (1) - buy chips
             (2) - wager (maybe limits)
             (3) - deal cards (clockwise):
                     first round: face up players, face down dealer
                     second round: face up both
                   two cards (face-up) for playesr, two cards (alternate) for dealer
             (4) - playing hand:
                     Blackjack: instant win, or draw if dealer has
                     Stand: keep current hand, dealer moves onto next player
                     Hit: dealer deals another card, until player chooses Stand or goes Bust(>21)
                     Double Down: double wager and dealt 1 more card (no more cards can be dealt)
                     Split: (card pairs) double wager, cards go in seperate hands, 1 new card is added to each.
                     Surrender: returns half of wager, removes player from round
             (5) - Dealer's hand plays:
                     Value >16: Stand
                     Value <17: Hit
                     Soft 17: (Ace, 6), choice to Hit
             (6) - Payout:
                     Dealer bust: 1x wager to remaining hands
                     Dealer 17-21: player > dealer -> 1x wager, player < dealer -> sweep (0x wager), player = dealer -> push (-)
            */

            
            BlackJackGame game = new BlackJackGame(); //creates new deck of cards

            game.Play_All(); //plays 1 round
            
            Console.WriteLine("Program finished.");
        }
    }
}
