using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Card
    {

        //This class stores the card properties
        public string value;
        public string suit;
        public int num_value;

        //The purpose of this method,is to store the card properties when a deck of cards get generated
        public Card(string val, string ste, int num)
        {
            value = val;
            suit = ste;
            num_value = num;
        }

    }
}
