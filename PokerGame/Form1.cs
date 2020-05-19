using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerGame
{
    public partial class Form1 : Form
    {
        DeckOfCards myDeckOfCards = new DeckOfCards();

        // int arrays to keep track of DeckOfCards.deck[index] for each hand
        int[] hand1Nums = new int[5];
        int[] hand2Nums = new int[5];

        //pictureBox arrays to make it easier to assign cards to pictureBoxes
        PictureBox[] hand1PB = new PictureBox[5];
        PictureBox[] hand2PB = new PictureBox[5];

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

        // ranks for each suit of card
        public Dictionary<string, int> suitRank = new Dictionary<string, int>()
        {
            {"Clubs", 1 },
            {"Diamonds", 2 },
            {"Hearts", 3 },
            {"Spades", 4 },
        };

        // ranks for each face value of card
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
            hand1newCardButton.Enabled = false;
            hand2newCardButton.Enabled = false;

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            myDeckOfCards.currentCard = 0; // reset currentCard value so generateHands can work again
            myDeckOfCards.Shuffle(); // reshuffle the deck
            hand1newCardButton.Enabled = false;
            hand2newCardButton.Enabled = false;
        }

        // deals current card in deck/increments in class and shows correct image for each card into picturebox
        // while setting array of int to hand1 and hand2
        // thus creating a "hand" for hand 1 and 2 by being able to retrieve deck.value at hand[index]
        // this makes it easier to then exchange cards later, because we can store the new integers into hand[index]
        // also deals by alternating cards from player 1 to player 2 instead of 5 straight to player 1 then player 2
        private void generateHandsToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            // set existing pictureboxes into the array of pictureboxes for each hand
            for (int i = 0; i < 5; i++)
            {
                hand1PB[i] = (PictureBox)Controls.Find("hand1PicBox" + (i + 1).ToString(), true)[0];
                hand2PB[i] = (PictureBox)Controls.Find("hand2PicBox" + (i + 1).ToString(), true)[0];
            }

            while (myDeckOfCards.currentCard <= 10)
            {
                for (int i = 0; i < 5; i++)
                {
                    hand1Nums[i] = myDeckOfCards.currentCard;
                    hand1PB[i].BackgroundImage = cardToImage[myDeckOfCards.DealCard().ToString()];
                    hand2Nums[i] = myDeckOfCards.currentCard;
                    hand2PB[i].BackgroundImage = cardToImage[myDeckOfCards.DealCard().ToString()];
                }
            }
            // enable deal new card buttons
            hand1newCardButton.Enabled = true;
            hand2newCardButton.Enabled = true;
            //disable deal hands
            generateHandsToolStripMenuItem.Enabled = false;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // is royal flush
        private bool isRoyal(ref int[] handGiven)
        {
            bool isRoyal = false;
            List<int> numFaceRanks = new List<int>();
            int highStraight = 0;

            for (int i = 0; i < 5; i++)
            {
                numFaceRanks.Add(faceRank[myDeckOfCards.deck[handGiven[i]].Face]);
            }

            for (int i = 0; i < numFaceRanks.Count; i++)
            {
                highStraight += numFaceRanks[i];
            }
                        
            if (highStraight == 60)
                isRoyal = true;
            return isRoyal;
        }

        // return is full house exists
        private bool isFullHouse(ref int[] handGiven)
        {
            List<int> numFaceRanks = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                numFaceRanks.Add(faceRank[myDeckOfCards.deck[handGiven[i]].Face]);
            }

            numFaceRanks.Sort();

            if (((numFaceRanks[0] == numFaceRanks[1] && numFaceRanks[0] == numFaceRanks[2] && numFaceRanks[3] == numFaceRanks[4])) ||
                (numFaceRanks[0] == numFaceRanks[1] && numFaceRanks[2] == numFaceRanks[3] && numFaceRanks[2] == numFaceRanks[4]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // return if flush exists by checking that each card's Suit is the same
        private bool isFlush(ref int[] handGiven)
        {
            bool isFlush = false;
            int suit = 0;

            for (int i = 0; i < 4; i++)
            {
                if (myDeckOfCards.deck[handGiven[i]].Suit == myDeckOfCards.deck[handGiven[i+1]].Suit)
                    suit +=1;
            }

            if (suit == 4)
            {
                isFlush = true;
            }
            else
            {
                isFlush = false;
            }
            return isFlush;
        }

        // returns true if straight exists
        // straight exists if for all nums in order, num[i] - num[i-1] = 1;
        // exception for ace,2,3,4,5 since ace rank = 14
        private bool isStraight(ref int[] handGiven)
        {
            bool isStraight = false;
            List<int> numFaceRanks = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                numFaceRanks.Add(faceRank[myDeckOfCards.deck[handGiven[i]].Face]);
            }

            numFaceRanks.Sort();

            // check for ace,2,3,4,5
            if (numFaceRanks[4] == 14 && (numFaceRanks[4] - numFaceRanks[0] == 12))
            {
                for (int i = 3; i > 0; i--)
                {
                    if (numFaceRanks[i] - numFaceRanks[i - 1] == 1)
                    {
                        isStraight = true;
                    }
                    else
                    {
                        isStraight = false;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 4; i > 0; i--)
                {
                    if (numFaceRanks[i] - numFaceRanks[i - 1] == 1)
                    {
                        isStraight = true;
                    }
                    else
                    {
                        isStraight = false;
                        break;
                    }
                }
            }
            return isStraight;
        }

        // returns if four of a kind exists if faceVal >= 4
        private bool isQuads(ref int[] handGiven)
        {
            List<int> numFaceRanks = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                numFaceRanks.Add(faceRank[myDeckOfCards.deck[handGiven[i]].Face]);
            }

            numFaceRanks.Sort();

            if (((numFaceRanks[0] == numFaceRanks[1] && numFaceRanks[0] == numFaceRanks[2] && numFaceRanks[0] == numFaceRanks[3])) ||
                (numFaceRanks[4] == numFaceRanks[1] && numFaceRanks[4] == numFaceRanks[3] && numFaceRanks[4] == numFaceRanks[1]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // returns if three of a kind exists if faceVal == 3
        private bool isTrips(ref int[] handGiven)
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

        private int CheckHand(ref int[]handGiven)
        {
            // return int to give hand a numerical value to compare with other hand

            // royal flush
            if ((isRoyal(ref handGiven)) && (isFlush(ref handGiven)) && (isStraight(ref handGiven)))
            {
                return 9;
            }
            // straight flush
            else if ((isFlush(ref handGiven)) && (isStraight(ref handGiven)))
            {
                return 8;
            }
            else if (isQuads(ref handGiven))
            {
                return 7;
            }
            // full house
            else if (isFullHouse(ref handGiven))
            {
                return 6;
            }
            else if (isFlush(ref handGiven))
            {
                return 5;
            }
            else if (isStraight(ref handGiven))
            {
                return 4;
            }           
            else if (isTrips(ref handGiven))
            {
                return 3;
            }
            else if (isTwoPair(ref handGiven))
            {
                return 2;
            }
            else if (isPair(ref handGiven))
            {
                return 1;
            }
            else
            {
                return 0; //nothing
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> newNums = new List<int>();

            // add number of which index to be changed for hand array
            if (hand1CheckBox1.Checked == false)
            {
                newNums.Add(0);
            }
            if (hand1CheckBox2.Checked == false)
            {
                newNums.Add(1);
            }
            if (hand1CheckBox3.Checked == false)
            {
                newNums.Add(2);
            }
            if (hand1CheckBox4.Checked == false)
            {
                newNums.Add(3);
            }
            if (hand1CheckBox5.Checked == false)
            {
                newNums.Add(4);
            }

            for (int i = 0; i < newNums.Count; i++)
            {
                // handNums[whatever this element is] so the card at that position can get a new card
                hand1Nums[newNums[i]] = myDeckOfCards.currentCard;
                hand1PB[newNums[i]].BackgroundImage = cardToImage[myDeckOfCards.DealCard().ToString()];
            }
            //disable deal new card button
            hand1newCardButton.Enabled = false;
        }

        private void hand2newCardButton_Click(object sender, EventArgs e)
        {
            List<int> newNums = new List<int>();

            // add number of which index to be changed for hand array
            if (hand2CheckBox1.Checked == false)
            {
                newNums.Add(0);
            }
            if (hand2CheckBox2.Checked == false)
            {
                newNums.Add(1);
            }
            if (hand2CheckBox3.Checked == false)
            {
                newNums.Add(2);
            }
            if (hand2CheckBox4.Checked == false)
            {
                newNums.Add(3);
            }
            if (hand2CheckBox5.Checked == false)
            {
                newNums.Add(4);
            }

            for (int i = 0; i < newNums.Count; i++)
            {
                // handNums[whatever this element is] so the card at that position can get a new card
                hand2Nums[newNums[i]] = myDeckOfCards.currentCard;
                hand2PB[newNums[i]].BackgroundImage = cardToImage[myDeckOfCards.DealCard().ToString()];
            }
            //disable deal new card button
            hand2newCardButton.Enabled = false;
        }
        private void PrintHand(string player, int handVal)
        {
            switch(handVal)
            {
                case 1:
                    resultTextBox.Text += player + " has a pair!\r\n";
                    break;
                case 2:
                    resultTextBox.Text += player + " has two pairs!\r\n";
                    break;
                case 3:
                    resultTextBox.Text += player + " has a three of a kind!\r\n";
                    break;
                case 4:
                    resultTextBox.Text += player + " has a straight!\r\n";
                    break;
                case 5:
                    resultTextBox.Text += player + " has a flush!\r\n";
                    break;
                case 6:
                    resultTextBox.Text += player + " has a full house!\r\n";
                    break;
                case 7:
                    resultTextBox.Text += player + " has a four of a kind!\r\n";
                    break;
                case 8:
                    resultTextBox.Text += player + " has a straight flush!\r\n";
                    break;
                case 9:
                    resultTextBox.Text += player + " has a royal flush!\r\n";
                    break;
                default:
                    resultTextBox.Text += player + " has nothing!\r\n";
                    break;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // only compare hands when cards have been dealt and hands are in play
            if (generateHandsToolStripMenuItem.Enabled == false)
            {
                //send array of each hand to CheckHand and receive value for hand strength
                int hand1Value = CheckHand(ref hand1Nums);
                int hand2Value = CheckHand(ref hand2Nums);
                PrintHand("Player 1", hand1Value);
                PrintHand("Player 2", hand2Value);

                if (hand1Value > hand2Value)
                {
                    resultTextBox.Text += "Player 1 wins!";
                }
                else if (hand1Value < hand2Value)
                {
                    resultTextBox.Text += "Player 2 wins!";
                }
                else
                {
                    resultTextBox.Text += "Let's call it a tie game for now! Thanks for understanding";
                }
            }
            else
            {
                MessageBox.Show("Please deal cards first.");
            }
            button1.Enabled = false;
        }
    }
}
