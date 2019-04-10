using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new TwentyOneGame();
            Player<Card> alexei = new Player<Card> { Name = "Alexei" };
            Player<Card> jesse = new Player<Card> { Name = "Jesse" };
            Player<Card> bill = new Player<Card> { Name = "Bill" };
            Player<Card> josh = new Player<Card> { Name = "Josh" };

            //game.Players = new List<Player<Card>>() { };
            //game += josh;
            //game += alexei;
            //game.ListPlayers();
            //Console.ReadLine();

            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);

            //}
            //Console.WriteLine(deck.Cards.Count());
            //Console.ReadLine();

        }
    }
}
