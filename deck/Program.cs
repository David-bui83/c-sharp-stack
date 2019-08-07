using System;

namespace deck
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            newDeck.Show();
            newDeck.Shuffle();
            newDeck.Show();
            newDeck.deal();
            Player player1 = new Player("John");
            player1.Draw(newDeck);
            player1.Draw(newDeck);
            player1.ShowHand();
        }
    }
}
