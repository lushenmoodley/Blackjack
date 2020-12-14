using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class StartUp
    {
        public void Initiate()
        {
            Console.WriteLine("-------BlackJack Game-------");

            Deck objDeck = new Deck();
            objDeck.GenerateADeck();
            objDeck.Shuffle();
            string name = "";

            if (name != "")
            {
                Console.WriteLine("Please enter a username ");
                name = Console.ReadLine();
            }

            Player objPlayer = new Player(name);
            objPlayer.Draw(objDeck);
            
        }
    }
}
