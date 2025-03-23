namespace Card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Card myCard = new Card(rnd.Next(13), rnd.Next(4));

            Console.WriteLine("The card is of suit " + myCard.GetSuit());
            Console.WriteLine("The card is of rank " + myCard.GetRank());

            Console.WriteLine(myCard.GetSuitAsString());
            Console.WriteLine(myCard.GetRankAsString());
            Console.WriteLine(myCard.GetName());

            Card[] cards = new Card[52];

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cards[j*13 + i] = (new Card(i, j));
                }
            }

            for (int i = 0; i < cards.Length; i++) { Console.WriteLine(cards[i].GetName()); }
        }
    }
}
