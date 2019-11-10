using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_FiveCardDraw
{
    class Card
    {
        private string rank;
        private string suit;
        private int value;

        public string Rank { get => rank; set => rank = value; }
        public string Suit { get => suit; set => suit = value; }
        public int Value { get => value; set => this.value = value; }

        public Card(string rank, string suit, int value)
        {
            this.rank = rank;
            this.suit = suit;
            this.value = value;
        }

        public override string ToString()
        {
            return string.Format("{0,2}{1}", rank, suit);
        }
    }
}

