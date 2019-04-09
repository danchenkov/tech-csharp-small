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
            Player alexei = new Player { Name = "Alexei" };
            Player jesse = new Player { Name = "Jesse" };
            Player bill = new Player { Name = "Bill" };
            Player josh = new Player { Name = "Josh" };

            game.Players = new List<Player>() { jesse, bill, josh };
            game += alexei;
            game.ListPlayers();
            Console.ReadLine();

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
