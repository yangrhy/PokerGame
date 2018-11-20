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
        DeckOfCards myDeckOfCards = new DeckOfCards();

        // int array to keep track of DeckOfCards.deck[num]
        // stores 1,2,3,4,5 and deck[1] = card that was given to that hand
        int[] hand1Nums = new int[5];
        int[] hand2Nums = new int[5];

        // Dictionary created to get correct image corresponding to what card is dealt
        public Dictionary<string, Image> cardToImage = new Dictionary<string, Image>()
        {
            {"Clubs Ace", Properties.Resources.c1 },
            {"Clubs Deuce", Properties.Resources.c2 },
            {"Clubs Three", Properties.Resources.c3 },
            {"Clubs Four", Properties.Resources.c4 },
            {"Clubs Five", Properties.Resources.c5 },
            {"Clubs Six", Properties.Resources.c6 },
            {"Clubs Seven", Properties.Resources.c7},
            {"Clubs Eight", Properties.Resources.c8 },
            {"Clubs Nine", Properties.Resources.c9 },
            {"Clubs Ten", Properties.Resources.c10 },
            {"Clubs Jack", Properties.Resources.cj },
            {"Clubs Queen", Properties.Resources.cq },
            {"Clubs King", Properties.Resources.ck },
            {"Hearts Ace", Properties.Resources.h1 },
            {"Hearts Deuce", Properties.Resources.h2 },
            {"Hearts Three", Properties.Resources.h3 },
            {"Hearts Four", Properties.Resources.h4 },
            {"Hearts Five", Properties.Resources.h5 },
            {"Hearts Six", Properties.Resources.h6 },
            {"Hearts Seven", Properties.Resources.h7},
            {"Hearts Eight", Properties.Resources.h8 },
            {"Hearts Nine", Properties.Resources.h9 },
            {"Hearts Ten", Properties.Resources.h10 },
            {"Hearts Jack", Properties.Resources.hj },
            {"Hearts Queen", Properties.Resources.hq },
            {"Hearts King", Properties.Resources.hk },
            {"Diamonds Ace", Properties.Resources.d1 },
            {"Diamonds Deuce", Properties.Resources.d2 },
            {"Diamonds Three", Properties.Resources.d3 },
            {"Diamonds Four", Properties.Resources.d4 },
            {"Diamonds Five", Properties.Resources.d5 },
            {"Diamonds Six", Properties.Resources.d6 },
            {"Diamonds Seven", Properties.Resources.d7},
            {"Diamonds Eight", Properties.Resources.d8 },
            {"Diamonds Nine", Properties.Resources.d9 },
            {"Diamonds Ten", Properties.Resources.d10 },
            {"Diamonds Jack", Properties.Resources.dj },
            {"Diamonds Queen", Properties.Resources.dq },
            {"Diamonds King", Properties.Resources.dk },
            {"Spades Ace", Properties.Resources.s1 },
            {"Spades Deuce", Properties.Resources.s2 },
            {"Spades Three", Properties.Resources.s3 },
            {"Spades Four", Properties.Resources.s4 },
            {"Spades Five", Properties.Resources.s5 },
            {"Spades Six", Properties.Resources.s6 },
            {"Spades Seven", Properties.Resources.s7},
            {"Spades Eight", Properties.Resources.s8 },
            {"Spades Nine", Properties.Resources.s9 },
            {"Spades Ten", Properties.Resources.s10 },
            {"Spades Jack", Properties.Resources.sj },
            {"Spades Queen", Properties.Resources.sq },
            {"Spades King", Properties.Resources.sk },
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myDeckOfCards.Shuffle();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            myDeckOfCards.currentCard = 0; // reset currentCard value so generateHands can work again
            myDeckOfCards.Shuffle(); // reshuffle the deck
        }

        private void generateHandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // deal cards as long as current card is no more than 10 (5 cards per player)
            while (myDeckOfCards.currentCard <= 10)
            {
                hand1Nums[0] = myDeckOfCards.currentCard;
                hand1PicBox1.BackgroundImage = cardToImage[myDeckOfCards.DealCard().ToString()];
                hand2Nums[0] = myDeckOfCards.currentCard;
                hand2PicBox1.BackgroundImage = cardToImage[myDeckOfCards.DealCard().ToString()];
                hand1Nums[1] = myDeckOfCards.currentCard;
                hand1PicBox2.BackgroundImage = cardToImage[myDeckOfCards.DealCard().ToString()];
                hand2Nums[1] = myDeckOfCards.currentCard;
                hand2PicBox2.BackgroundImage = cardToImage[myDeckOfCards.DealCard().ToString()];
                hand1Nums[2] = myDeckOfCards.currentCard;
                hand1PicBox3.BackgroundImage = cardToImage[myDeckOfCards.DealCard().ToString()];
                hand2Nums[2] = myDeckOfCards.currentCard;
                hand2PicBox3.BackgroundImage = cardToImage[myDeckOfCards.DealCard().ToString()];
                hand1Nums[3] = myDeckOfCards.currentCard;
                hand1PicBox4.BackgroundImage = cardToImage[myDeckOfCards.DealCard().ToString()];
                hand2Nums[3] = myDeckOfCards.currentCard;
                hand2PicBox4.BackgroundImage = cardToImage[myDeckOfCards.DealCard().ToString()];
                hand1Nums[4] = myDeckOfCards.currentCard;
                hand1PicBox5.BackgroundImage = cardToImage[myDeckOfCards.DealCard().ToString()];
                hand2Nums[4] = myDeckOfCards.currentCard;
                hand2PicBox5.BackgroundImage = cardToImage[myDeckOfCards.DealCard().ToString()];
               
            }
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isFlush(ref int[]handGiven)
        {
            bool isFlush = false;
            int suit = 0;
            for (int i = 0; i < 5; i++)
                for (int k = i + 1; k < 5; k++)
                    if (myDeckOfCards.deck[handGiven[i]].Suit == myDeckOfCards.deck[handGiven[k]].Suit)
                        suit++;
            if (suit == 5)
                isFlush = true;
            return isFlush;
        }

        private string CheckPairs(ref int[]handGiven)
        {
            int faceVal = 0;
            string returnFace = "";
            for (int i = 0; i < 5; i++)
                for (int k = i + 1; k < 5; k++)
                    if (myDeckOfCards.deck[handGiven[i]].Face == myDeckOfCards.deck[handGiven[k]].Face)
                    {
                        returnFace = myDeckOfCards.deck[handGiven[i]].Face;
                        faceVal++;
                    }
            if (faceVal == 1)
                return "one pair of " + returnFace + "s";
            else if (faceVal == 2)
                return "two pairs\r\n";
            else if (faceVal > 2)
                return faceVal.ToString() + " of a kind";
            else
                return "nothing";
        }
        private void CheckHand()
        {

            // return last in else if statement, because it is lowest hand compared
            hand1TextBox.Text = "Player 1 has " + CheckPairs(ref hand1Nums);
            hand2TextBox.Text = "Player 2 has " + CheckPairs(ref hand2Nums);
                

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myDeckOfCards.currentCard >= 10)
            {
                CheckHand();
            }
            else
            {
                MessageBox.Show("Please deal cards first.");
            }
        }
    }
}
