using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Player
    {
        public long total = 0;
        public int count = 0;
        public string username;

        public Player(string name)
        {
            username = name;
        }
        public void Draw(Deck deckname)
        {

            Card newcard = deckname.Deal();
            count++;

            total += Convert.ToInt64(newcard.num_value);
            Console.WriteLine();

            Console.WriteLine("You have the following card: " + newcard.value + " of " + newcard.suit + "." + "Your current total: " + total);

            if (count < 2)//draws the player 2 cards first
            {
                Draw(deckname);
            }
            else
            {   //General point assigning rules
                if (total > 21)
                {
                    Console.WriteLine("You Lose");
                    return;
                }
                else
                if (total == 21)
                {
                    Console.WriteLine("Black-Jack!");
                    return;
                }

                Console.WriteLine("Would you like to draw again? Y Or N");
                string answer = Console.ReadLine();

                if (answer.ToUpper() == "Y")
                {
                    Draw(deckname);
                }
                else
                if (answer.ToUpper() == "N")
                {
                    
                    Dealer objD = new Dealer();

                    objD.Draw(deckname);

                    if (objD.total == 21)
                    {
                        Console.WriteLine("Dealer Won,you lose");
                    }
                    else
                    if (objD.total > 21)
                    {
                        Console.WriteLine("Dealer Bust,you win!");
                    }
                    else
                    if (objD.total > total)
                    {
                        Console.WriteLine("Dealer has won");
                    }
                    else
                    if (objD.total < total)
                    {
                        Console.WriteLine("You have won");
                    }
                    else
                    if (objD.total == total)
                    {
                        Console.WriteLine("Its a tie");
                    }
                }
            }

            Console.WriteLine("Would You Like To Play Again? Y Or N");
            string replay = Console.ReadLine();

            if (replay.ToUpper() == "Y")
            {
                StartUp objStart = new StartUp();
                objStart.Initiate();

            }
            else
            {
                Environment.Exit(-1);
            }
        }

    }
}

