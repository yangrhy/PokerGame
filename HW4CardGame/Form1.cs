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

        // int arrays to keep track of DeckOfCards.deck[index] for each hand
        int[] hand1Nums = new int[5];
        int[] hand2Nums = new int[5];

        //string returnFace = ""; //return face of card (need for 
        // string returnSuit = ""; // return suit

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

        public Dictionary<string, int> suitRank = new Dictionary<string, int>()
        {
            {"Clubs", 1 },
            {"Diamonds", 2 },
            {"Hearts", 3 },
            {"Spades", 4 },
        };

        public Dictionary<string, int> faceRank = new Dictionary<string, int>()
        {
            {"Deuce", 2 },
            {"Three", 3 },
            {"Four", 4 },
            {"Five", 5 },
            {"Six", 6 },
            {"Seven", 7 },
            {"Eight", 8 },
            {"Nine", 9 },
            {"Ten", 10 },
            {"Jack", 11 },
            {"Queen", 12 },
            {"King", 13 },
            {"Ace", 14 },
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

        // deals current card in deck/increments in class and shows correct image for each card into picturebox
        // while setting array of int to hand1 and hand2
        // thus creating a "hand" for hand 1 and 2 by being able to retrieve deck.value at hand[index]
        // this makes it easier to then exchange cards later, because we can store the new integers into hand[index]
        // also deals by alternating cards from player 1 to player 2 instead of 5 straight to player 1 then player 2
        private void generateHandsToolStripMenuItem_Click(object sender, EventArgs e)
        {         
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

        // return if flush exists by checking that each card's Suit is the same
        // if suit != 5 then flush does not exist
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

        // returns true if straight exists
        private bool isStraight(ref int[] handGiven)
        {
            bool isStraight = false;
            List<int> numFaceRanks = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                numFaceRanks.Add(faceRank[myDeckOfCards.deck[handGiven[i]].Face]);
            }

            numFaceRanks.Sort();

            for (int i = 4; i > 0; i--)
            {
                if (numFaceRanks[i] - numFaceRanks[i - 1] == 1)
                {
                    isStraight = true;
                }
                else
                {
                    isStraight = false;
                }
            }
                       
            return isStraight;
        }

        // returns if four of a kind exists if faceVal >= 4
        private bool isFourOfKind(ref int[] handGiven)
        {
            int faceVal = 0;
            //returnFace = "";
            for (int i = 0; i < 5; i++)
                for (int k = i + 1; k < 5; k++)
                    if (myDeckOfCards.deck[handGiven[i]].Face == myDeckOfCards.deck[handGiven[k]].Face)
                    {
                        //returnFace = myDeckOfCards.deck[handGiven[i]].Face;
                        faceVal++;
                    }
            if (faceVal >= 4)
                return true;
            else
                return false;
        }

        // returns if three of a kind exists if faceVal == 3
        private bool isThreeOfKind(ref int[] handGiven)
        {
            int faceVal = 0;
           // returnFace = "";
            for (int i = 0; i < 5; i++)
                for (int k = i + 1; k < 5; k++)
                    if (myDeckOfCards.deck[handGiven[i]].Face == myDeckOfCards.deck[handGiven[k]].Face)
                    {
                       // returnFace = myDeckOfCards.deck[handGiven[i]].Face;
                        faceVal++;
                    }
            if (faceVal == 3)
                return true;
            else
                return false;
        }

        // returns if two pairs exists if faceVal == 2
        private bool isTwoPair(ref int[] handGiven)
        {
            int faceVal = 0;
           // returnFace = "";
            for (int i = 0; i < 5; i++)
                for (int k = i + 1; k < 5; k++)
                    if (myDeckOfCards.deck[handGiven[i]].Face == myDeckOfCards.deck[handGiven[k]].Face)
                    {
                      //  returnFace = myDeckOfCards.deck[handGiven[i]].Face;
                        faceVal++;
                    }
            if (faceVal == 2)
                return true;
            else
                return false;
        }


        private bool isPair(ref int[]handGiven)
        {
            int faceVal = 0;
           // returnFace = "";
            for (int i = 0; i < 5; i++)
                for (int k = i + 1; k < 5; k++)
                    if (myDeckOfCards.deck[handGiven[i]].Face == myDeckOfCards.deck[handGiven[k]].Face)
                    {
                       // returnFace = myDeckOfCards.deck[handGiven[i]].Face;
                        faceVal++;
                    }
            if (faceVal == 1)
                return true;
            else
                return false;
        }

        private void CheckHand(ref int[]handGiven)
        {
            // return last in else if statement, because it is lowest hand compared
            if (isFlush(ref handGiven))
            {
                hand1TextBox.Text = "Player one has flush";
            }
            else if (isStraight(ref handGiven))
            {
                hand1TextBox.Text = "Player one has straight";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if currentCard >= 10 then that means cards have been dealt and hands are in play
            if (myDeckOfCards.currentCard >= 10)
            {
                // Send correct hand array depending on which tab is selected
                if (tabControl1.SelectedTab == tabControl1.TabPages["Player 1 Hand"])
                {
                    CheckHand(ref hand1Nums);
                }
                else
                {
                    CheckHand(ref hand2Nums);
                }
            }
            else
            {
                MessageBox.Show("Please deal cards first.");
            }
        }
    }
}
