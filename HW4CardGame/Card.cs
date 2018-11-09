using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4CardGame
{
    class Card
    {
        private string face { get; }
        private string suit { get; }

        public Card(string cardFace, string cardSuit)
        {
            face = cardFace;
            suit = cardSuit;
        }

        public override string ToString() => $"{face} of {suit}";
        
    }
}
