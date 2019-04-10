using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    abstract class Game
    {
        public List<Player<Card>> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play();

        public virtual void ListPlayers()
        {
            foreach (Player<Card> player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
