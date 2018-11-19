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

        private void generateHand1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hand1PicBox1.Image = cardToImage[myDeckOfCards.DealCard().ToString()];
            hand1PicBox2.Image = cardToImage[myDeckOfCards.DealCard().ToString()];
            hand1PicBox3.Image = cardToImage[myDeckOfCards.DealCard().ToString()];
            hand1PicBox4.Image = cardToImage[myDeckOfCards.DealCard().ToString()];
            hand1PicBox5.Image = cardToImage[myDeckOfCards.DealCard().ToString()];

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }
}
