using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4CardGame
{
    class DeckOfCards
    {
        private Card[] deck;
        private int currentCard;
        private const int NUMBER_OF_CARDS = 52;
        private Random randomNumbers;

        public DeckOfCards()
        {
            string[] faces = {"Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven",
                          "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            deck = new Card[NUMBER_OF_CARDS];
            currentCard = 0;
            randomNumbers = new Random();

            for (var count = 0; count < deck.Length; ++count)
            {
                deck[count] = new Card(faces[count % 13], suits[count / 13]);
            }
        }
        
        public void Shuffle()
        {
            currentCard = 0;
            
            for (var first = 0; first < deck.Length; ++first)
            {
                var second = randomNumbers.Next(NUMBER_OF_CARDS);

                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }

        public Card DealCard()
        {
            if (currentCard < deck.Length)
            {
                return deck[currentCard++];
            }
            else
            {
                return null;
            }
        }
    }
}
