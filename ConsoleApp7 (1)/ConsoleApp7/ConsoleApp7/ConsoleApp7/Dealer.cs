using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Dealer
    {
        public int total = 0;
        public void Draw(Deck deckname)//this method generates the dealers cards
        {         
           Card newCard = deckname.Deal();
           total += newCard.num_value;
           Console.WriteLine("Dealer Drew a " + newCard.value + " of " + newCard.suit + ",the dealer total is " + total);

           if(total<=17)
           {
             Draw(deckname);
           }
            
        }

    }
}
