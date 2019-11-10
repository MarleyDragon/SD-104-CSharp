using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_FiveCardDraw
{
    class FiveCardDraw
    {
        public List<Card> PlayerHand { get; set; }

        public DeckOfCards deckOfCards { get; set; }

        public FiveCardDraw()
        {
            deckOfCards = new DeckOfCards();
            deckOfCards.Shuffle();
            PlayerHand = new List<Card>();

        }

        private bool[] Discard;

        public void PlayRound()
        {
            Discard = new bool[5] { false, false, false, false, false };
            string userChoice;
            int discardMe = 0;

            for (int n = 0; n < 5; n++)
            {
                PlayerHand.Add(deckOfCards.Deal());

            }
            do
            {
                ShowPlayerHand();
                Console.WriteLine("Type the number of the card in your hand and hit Enter to toggle between Keep/Discard. Type 'D' to finalize discard.");
                userChoice = Console.ReadLine();

                //input validation
                while (userChoice != "D" && !int.TryParse(userChoice, out discardMe))
                {
                    Console.WriteLine("Invalid Choice.Try Again: ");
                    userChoice = Console.ReadLine();

                }
                if (userChoice != "D" && discardMe > 0 && discardMe < 6)
                {
                    Discard[discardMe - 1] = Discard[discardMe - 1] == true ? false : true;
                   

                }
            } while (userChoice != "D");

            FinalizeDiscard();
            ShowPlayerHand();
        }

        public void FinalizeDiscard()
        {
            for(int n=0; n <PlayerHand.Count; n++)
            {
                if (Discard[n])
                    {
                    deckOfCards.Deck.Add(PlayerHand[n]);
                    PlayerHand[n] = deckOfCards.Deal();

                }
            }
            Discard = new bool[5] { false, false, false, false, false };

        }

        public void ShowPlayerHand()
        {
            for (int n = 0; n < PlayerHand.Count; n++)
            {
                if (!Discard[n])
                {
                    Console.WriteLine("Card #" + (n + 1) + ": " + PlayerHand[n]);
                }
                else
                {
                    Console.WriteLine("Card #" + (n + 1) + ": " + PlayerHand[n] +"<----- Discard");
                }


            }
        }

    }
}

