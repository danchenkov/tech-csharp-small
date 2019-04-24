using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player("Alexei");

            Console.WriteLine("Welcome to Grand Hotel and Casino. Let's start by telling me your name");
            string playerName = Console.ReadLine();
            
            int bank;
            do
            {
                Console.WriteLine("And how much money did you bring today?");
            } while (!int.TryParse(Console.ReadLine(), out bank));

            //Console.WriteLine(playerName + " brought $" + bank + " and is willing to give it all out.");
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);

            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing. Bye. Bring more money and friends!");
            }
            //Game game = new TwentyOneGame();
            //Player<Card> alexei = new Player<Card> { Name = "Alexei" };
            //Player<Card> jesse = new Player<Card> { Name = "Jesse" };
            //Player<Card> bill = new Player<Card> { Name = "Bill" };
            //Player<Card> josh = new Player<Card> { Name = "Josh" };

            //game.Players = new List<Player<Card>>() { };
            ////game += josh;
            ////game += alexei;
            //game.Players.Add(alexei);
            //game.Players.Add(bill);
            //game.Players.Add(jesse);
            //game.Players.Add(josh);
            //game.ListPlayers();
            //Console.ReadLine();

            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);

            //}
            Console.ReadLine();

        }
    }
}
