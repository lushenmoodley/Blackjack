using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Deck
    {
      //An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).
      public enum cardSuit
      {
         Club,Spades,Hearts,Diamonds
      }

      public enum cardValue
      {
         Ace,Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
      }

      public Card[] cards = new Card[52];//this array stores 52 cards

      public void GenerateADeck()
      {
         int idx = 0;
         int num = 1;

               string getCardValue = "";
               string getCardSuit = "";

           
               foreach (int cardValue in Enum.GetValues(typeof(cardValue)))
               {
                   foreach (int cardSuitValue in Enum.GetValues(typeof(cardSuit)))//each card value gets a suite value
                {
                       getCardValue = ((cardValue)cardValue).ToString();
                       getCardSuit = ((cardSuit)cardSuitValue).ToString();
                        
                       
                       switch (getCardValue)
                       {
                           case "Jack":
                           case "Queen":
                           case "King":
                           cards[idx] = new Card(getCardValue, getCardSuit, 10);
                               break;
                           default:
                           cards[idx] = new Card(getCardValue, getCardSuit, num);
                           break;
                       }

                       idx++;
                   }

                   num++;
               }
     }

       public void Shuffle()
       {
            Console.WriteLine("Dealer shuffling the Deck...... ");
            dynamic temp = null;
            Random rand = new Random();//the random class provides functionality to generate random numbers
            for (int i = 0; i < cards.Length; i++)
            {
                int j = rand.Next(0, 52);//this method generates random numbers from zero to fifty-two
                temp = cards[i];
                cards[i] = cards[j];//It goes to the built card list and swaps the 1st card position with the newly generated number.The newly generated card becomes the 1st card and the inital first card takes the position of generated position
                cards[j] = temp;
            }
       }

       public Card Deal()
       {//This pops each item out of the card queue.
            
          for (int i = 0; i < 53; i++)
          {
             if (cards[i] != null)
             {
                 Card singlecard = cards[i];//Each card is popped out of the array list 
                 cards[i] = null;//Once the popped out in ascending order its assigned a null value
                 return singlecard;//The popped out card,is returned with its associated card properties
             }
          }
          return new Card("nocard", "nocard", 0);
       }

    }
}
