using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack_Project
{
    public partial class Blackjack : Form
    {
        List<Card> PlayerCards = new List<Card>()
        {
            new Card(null,0,null)
        };

        List<Card> ComputerCards = new List<Card>()
        {
            new Card(null,0,null)
        };

        int bet = 200;
        int playercardSum = 0;
        int computercardSum = 0;
        Random random = new Random();
        List<int> used = new List<int>();
        List<int> cardUsed = new List<int>();
        List<PictureBox> playerPictureBox = new List<PictureBox>();
        List<PictureBox> computerPictureBox = new List<PictureBox>();

        List<Card> deck = new List<Card>()
        {
            new Card("Two Clubs", 2, "CardsPictures/Clubs/2C.png"), // 0
            new Card("Three Clubs", 3, "CardsPictures/Clubs/3C.png"), // 1
            new Card("Four Clubs", 4, "CardsPictures/Clubs/4C.png"), // 2
            new Card("Five Clubs", 5, "CardsPictures/Clubs/5C.png"), // 3
            new Card("Six Clubs", 6, "CardsPictures/Clubs/6C.png"), // 4
            new Card("Seven Clubs", 7, "CardsPictures/Clubs/7C.png"), // 5
            new Card("Eight Clubs", 8, "CardsPictures/Clubs/8C.png"), // 6
            new Card("Nine Clubs", 9, "CardsPictures/Clubs/9C.png"), // 7
            new Card("Ten Clubs", 10, "CardsPictures/Clubs/10C.png"), // 8
            new Card("Jack Clubs", 10, "CardsPictures/Clubs/JC.png"), // 9
            new Card("Queen Clubs", 10, "CardsPictures/Clubs/QC.png"), // 10
            new Card("King Clubs", 10, "CardsPictures/Clubs/KC.png"), // 11
            new Card("Ace Clubs", 11, "CardsPictures/Clubs/AC.png"), // 12

            new Card("Two Diamonds", 2, "CardsPictures/Diamonds/2D.png"), // 13
            new Card("Three Diamonds", 3, "CardsPictures/Diamonds/3D.png"), // 14
            new Card("Four Diamonds", 4, "CardsPictures/Diamonds/4D.png"), // 15
            new Card("Five Diamonds", 5, "CardsPictures/Diamonds/5D.png"), // 16
            new Card("Six Diamonds", 6, "CardsPictures/Diamonds/6D.png"), // 17
            new Card("Seven Diamonds", 7, "CardsPictures/Diamonds/7D.png"), // 18
            new Card("Eight Diamonds", 8, "CardsPictures/Diamonds/8D.png"), // 19
            new Card("Nine Diamonds", 9, "CardsPictures/Diamonds/9D.png"), // 20
            new Card("Ten Diamonds", 10, "CardsPictures/Diamonds/10D.png"), // 21
            new Card("Jack Diamonds", 10, "CardsPictures/Diamonds/JD.png"), // 22
            new Card("Queen Diamonds", 10, "CardsPictures/Diamonds/QD.png"), // 23
            new Card("King Diamonds", 10, "CardsPictures/Diamonds/KD.png"), // 24
            new Card("Ace Diamonds", 11, "CardsPictures/Diamonds/AD.png"), // 25

            new Card("Two Hearts", 2, "CardsPictures/Hearts/2H.png"), // 26
            new Card("Three Hearts", 3, "CardsPictures/Hearts/3H.png"), // 27 
            new Card("Four Hearts", 4, "CardsPictures/Hearts/4H.png"), // 28
            new Card("Five Hearts", 5, "CardsPictures/Hearts/5H.png"), // 29
            new Card("Six Hearts", 6, "CardsPictures/Hearts/6H.png"), // 30
            new Card("Seven Hearts", 7, "CardsPictures/Hearts/7H.png"), // 31 
            new Card("Eight Hearts", 8, "CardsPictures/Hearts/8H.png"), // 32
            new Card("Nine Hearts", 9, "CardsPictures/Hearts/9H.png"), // 33
            new Card("Ten Hearts", 10, "CardsPictures/Hearts/10H.png"), // 34
            new Card("Jack Hearts", 10, "CardsPictures/Hearts/JH.png"), // 35
            new Card("Queen Hearts", 10, "CardsPictures/Hearts/QH.png"), // 36
            new Card("King Hearts", 10, "CardsPictures/Hearts/KH.png"), // 37 
            new Card("Ace Hearts", 11, "CardsPictures/Hearts/AH.png"), // 38

            new Card("Two Spades", 2, "CardsPictures/Spades/2S.png"), // 39
            new Card("Three Spades", 3, "CardsPictures/Spades/3S.png"), // 40
            new Card("Four Spades", 4, "CardsPictures/Spades/4S.png"), // 41
            new Card("Five Spades", 5, "CardsPictures/Spades/5S.png"), // 42
            new Card("Six Spades", 6, "CardsPictures/Spades/6S.png"), // 43
            new Card("Seven Spades", 7, "CardsPictures/Spades/7S.png"), // 44
            new Card("Eight Spades", 8, "CardsPictures/Spades/8S.png"), // 45
            new Card("Nine Spades", 9, "CardsPictures/Spades/9S.png"), // 46
            new Card("Ten Spades", 10, "CardsPictures/Spades/10S.png"), // 47
            new Card("Jack Spades", 10, "CardsPictures/Spades/JS.png"), // 48
            new Card("Queen Spades", 10, "CardsPictures/Spades/QS.png"),  // 49
            new Card("King Spades", 10, "CardsPictures/Spades/KS.png"), // 50
            new Card("Ace Spades", 11, "CardsPictures/Spades/AS.png") // 51  
        };

        public Blackjack()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fullReset();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (playercardSum > 0)
            {
                lblResult.Text = "The game is already started";
            }
            else
            {
                playercardSum = 0;
                computercardSum = 0;

                // Player
                int playerSelectFirstCard = selectCard();
                Card playerFirstCard = deck[playerSelectFirstCard];
                used.Add(playerSelectFirstCard);

                int playerSelectSecondCard = selectCard();
                Card playerSecondCard = deck[playerSelectSecondCard];
                used.Add(playerSelectSecondCard);

                PlayerCards.Add(playerFirstCard);
                PlayerCards.Add(playerSecondCard);

                pbFirstCard.ImageLocation = playerFirstCard.Image;
                pbFirstCard.SizeMode = PictureBoxSizeMode.AutoSize;

                pbSecondCard.ImageLocation = playerSecondCard.Image;
                pbSecondCard.SizeMode = PictureBoxSizeMode.AutoSize;

                // Computer
                int computerSelectFirstCard = selectCard();

                Card computerFirstCard = deck[computerSelectFirstCard];
                used.Add(computerSelectFirstCard);

                ComputerCards.Add(computerFirstCard);

                pbComputerFirstCard.ImageLocation = computerFirstCard.Image;
                pbComputerFirstCard.SizeMode = PictureBoxSizeMode.AutoSize;

                sumPlayer();
                sumComputer();

                lblPlayerCardsSum.Text = playercardSum.ToString();
                lblComputerCardsSum.Text = computercardSum.ToString();

                if (playercardSum == 21)
                {
                    lblResult.Text = "The sum of your cards is " + playercardSum + ", you win!";
                    MessageBox.Show("Blackjack!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblBalance.Text = "" + (int.Parse(lblBalance.Text) + bet*2);
                    reset();
                }

            }
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            if (playercardSum == 0)
            {
                lblResult.Text = "Click the Start button";
            }
            else
            {
                playercardSum = 0;
                int randomCard = selectCard();
                Card card = deck[randomCard];
                used.Add(randomCard);

                int milliseconds = 150;
                Task.Delay(milliseconds).Wait();

                PictureBox pb = new PictureBox
                {
                    Width = 90,
                    Height = 146,
                    Location = new Point(353 + playerPictureBox.Count * 94, 301),
                    ImageLocation = card.Image,
                    SizeMode = PictureBoxSizeMode.AutoSize
                };
                this.Controls.Add(pb);

                playerPictureBox.Add(pb);
                PlayerCards.Add(card);

                sumPlayer();

                lblPlayerCardsSum.Text = playercardSum.ToString();
                lblComputerCardsSum.Text = computercardSum.ToString();

                if (playercardSum > 21)
                {
                    lblResult.Text = "The sum of your cards is " + playercardSum + ", you lose!";
                    MessageBox.Show("You lose!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    lblBalance.Text = "" + (int.Parse(lblBalance.Text) - bet);
                    reset();

                }
                else if (playercardSum == 21)
                {
                    lblResult.Text = "The sum of your cards is " + playercardSum + ", now its computer's turn!";
                    MessageBox.Show("21! Now its computer's turn", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnStand_Click(sender,e);
                }
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            if (playercardSum == 0)
            {
                lblResult.Text = "Click the Start button";
                return;
            }

            sumComputer();
            while (computercardSum <= 16)
            {
                int randomCard = selectCard();
                Card card = deck[randomCard];
                used.Add(randomCard);

                PictureBox p4 = new PictureBox
                {
                    Width = 90,
                    Height = 146,
                    Location = new Point(258 + computerPictureBox.Count * 94, 37),
                    ImageLocation = card.Image,
                    SizeMode = PictureBoxSizeMode.AutoSize
                };
                this.Controls.Add(p4);

                computerPictureBox.Add(p4);
                ComputerCards.Add(card);

                sumComputer();

                lblPlayerCardsSum.Text = playercardSum.ToString();
                lblComputerCardsSum.Text = computercardSum.ToString();
            }

            if (computercardSum > 21)
            {
                lblResult.Text = "The sum of computer cards is " + computercardSum + ", you win!";
                MessageBox.Show("You win!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblBalance.Text = "" + (int.Parse(lblBalance.Text) + bet/2);
                reset();
            }
            else if (playercardSum < computercardSum)
            {
                lblResult.Text = "The sum of your cards is " + playercardSum + " and the sum of computer cards is " + computercardSum + ", you lose!";
                MessageBox.Show("You lose!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                lblBalance.Text = "" + (int.Parse(lblBalance.Text) - bet);
                reset();
            }
            else if (playercardSum == computercardSum)
            {
                lblResult.Text = "The sum of your cards is " + playercardSum + " and the sum of computer cards is " + computercardSum + ", so it's PUSH";
                MessageBox.Show("Push!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblBalance.Text = "" + (int.Parse(lblBalance.Text));
                reset();
            }
            else
            {
                lblResult.Text = "The sum of your cards is " + playercardSum + " and the sum of computer cards is " + computercardSum + ", you win!";
                MessageBox.Show("You win!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblBalance.Text = "" + (int.Parse(lblBalance.Text) + bet/2);
                reset();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            fullReset();
        }

        private void reset()
        {
            lblResult.Text = "";
            lblComputerCardsSum.Text = "0";
            lblPlayerCardsSum.Text = "0";

            displayBackCard(pbFirstCard);
            displayBackCard(pbSecondCard);

            displayBackCard(pbComputerFirstCard);

            foreach (PictureBox pb in playerPictureBox)
            {
                this.Controls.Remove(pb);
            }
            playerPictureBox = new List<PictureBox>();

            foreach (PictureBox pb in computerPictureBox)
            {
                this.Controls.Remove(pb);
            }
            computerPictureBox = new List<PictureBox>();

            playercardSum = 0;
            computercardSum = 0;

            PlayerCards.Clear();
            ComputerCards.Clear();
            used.Clear();
            cardUsed.Clear();
            lblResult.Text = "Player choice";
        }

        public void fullReset()
        {
            reset();

            lblBalance.Text = "1000";
        }

        public int selectCard()
        {
            int card;
            do
            {
                card = random.Next(0, deck.Count);
            } while (cardUsed.Contains(card));

            cardUsed.Add(card);

            return card;
        }

        private void sumPlayer()
        {
            playercardSum = 0;
            for (int i = 0; i < PlayerCards.Count; i++)
            {
                playercardSum += PlayerCards[i].Value;
            }

            if (playercardSum > 21)
            {
                foreach (Card card in PlayerCards)
                {
                    if (card.Value == 11)
                    {
                        playercardSum -= 10;
                        if (playercardSum <= 21)
                        {
                            break;
                        }
                    }
                }
            }
        }

        private void sumComputer()
        {
            computercardSum = 0;

            for (int i = 0; i < ComputerCards.Count; i++)
            {
                computercardSum += ComputerCards[i].Value;
            }

            if (computercardSum > 21)
            {
                foreach (Card card in ComputerCards)
                {
                    if (card.Value == 11)
                    {
                        computercardSum -= 10;
                        if (computercardSum <= 21)
                        {
                            break;
                        }
                    }
                }
            }
        }

        private void displayBackCard(PictureBox picturebox)
        {
            picturebox.ImageLocation = "backOfCard.png";
            picturebox.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
