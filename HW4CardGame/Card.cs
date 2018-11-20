using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4CardGame
{
    class Card
    {
        public string Face { get; } // Card’s face ("Ace", "Deuce", ...)
        public string Suit { get; } // Card’s suit ("Hearts", "Diamonds", ...)
        
        // two-parameter constructor initializes card's Face and Suit
        public Card(string face, string suit)
        {
            Face = face; // initialize face of card
            Suit = suit; // initialize suit of card
        }

        // return string representation of Card
        public override string ToString() => $"{Suit} {Face}";
    }
}
