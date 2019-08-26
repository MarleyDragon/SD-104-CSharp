using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_FiveCardDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            do
            {

                Console.OutputEncoding = System.Text.Encoding.Unicode;

                FiveCardDraw fiveCardDraw = new FiveCardDraw();
                fiveCardDraw.PlayRound();

                Console.WriteLine("Play Again? 'Y' for yes.");
                answer = Console.ReadLine();
                if (answer is "Y" || answer is "y")
                {
                                  
                }
                else
                {
                    Console.WriteLine("goodbye");

                    break;
                }
            } while (true);
Console.ReadLine();
            


            /*DeckOfCards myDeck = new DeckOfCards();

            myDeck.Shuffle(); 


            //cycle through deck
            foreach(Card card in myDeck.Deck)
            {
                Console.WriteLine(card.Rank+card.Suit);

            }
            Console.ReadLine(); */
            

        }
    }
}
