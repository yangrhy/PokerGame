using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4CardGame
{
    public partial class Form1 : Form
    {
        // create one Random object to share among DeckOfCards objects
        private static Random randomNumbers = new Random();

        private const int NumberOfCards = 52; // number of cards in a deck
        private Card[] deck = new Card[NumberOfCards]; // array of Card objects
        private int currentCard = 0; // index of next Card to be dealt (0-51)

        public Form1()
        {
            InitializeComponent();
        }

        // populates deck with objects of the Card class
        private void CreateDeck() { 
            string[] faces = {"Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven",
                            "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            for (var count = 0; count < deck.Length; ++count)
            {
                deck[count] = new Card(faces[count % 13], suits[count / 13]);
            }
        }

        // shuffles deck of Cards
        private void Shuffle()
        {
            // after shuffling, dealing restarts back at deck[0]
            currentCard = 0;

            // for each Card, pick another random Card and swap them
            for (var first = 0; first < deck.Length; ++first)
            {
                // selects a random number between 0 and 51 
                var second = randomNumbers.Next(NumberOfCards);

                // swap current Card with the randomly selected Card
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }

        // deals the next card in the deck
        private Card DealCard()
        {
            // determine whether Cards remain to be dealt
            if (currentCard < deck.Length)
            {
                // return current card in array
                return deck[currentCard++];
            }
            else
            {
                // indicate all cards are dealt
                return null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Shuffle();
        }
    }
}
