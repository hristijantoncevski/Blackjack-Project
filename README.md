# Blackjack

Blackjack е најпознатата и најраспространета казино игра низ целиот свет. За играње е потребно да се има еден шпил од карти, во кој има 52 карти.
Во самата играта луѓето не се напреваруваат меѓу себе, како на пример што е Покер, туку играат против dealer-от на карти.
Едни од најважните правила во играта се:
- Се игра до 21.
- Компјутерот извлекува карти се до 17.
- Секоја сума над 21 ви ги губи вложените пари или пак доколку dealer-от добие над 21 вие победувате.

При самото стартување на играта ке се види следниот интерфејс:
![image](https://user-images.githubusercontent.com/58054308/187395857-86ac80cf-2810-41e1-bcac-98c83bfb3451.png)

Со претискање на копчето "Start" играта започнува.
![image](https://user-images.githubusercontent.com/58054308/187396826-b2d90ab9-7e11-4b4b-a5a0-4d720151f4e0.png)
Добиваме две карти (во нашиот случај 10 и Ј) чија сума е 20. Со добиенот број можеме да направиме "Hit" или "Stand". 
Во Blackjack со правење "Hit" добиваме уште една карта, а со правење "Stand" сакаме да кажеме дека сме задоволни со бројот од добиените карти.
Во нашиот случај, 20 е многу добар број особено против 8 (чија е бројка на dealer-от/компјутерот), на кое правиме Stand.Гле
![image](https://user-images.githubusercontent.com/58054308/187399381-6587a6fa-cbe7-4ea6-b073-93bb710130fb.png)
Гледаме дека компјутерот има добиено 4 после првата карта со што сумата се прави на 12 , што значи дека мора да извлече уште барем 1 карта, која што во овој случај има вредност од 10 и го надминува бројот од 21 при што играчот победува.

Автоматска победа се случува кога првите две карти кои ги добиеме имаат сума од 21 и тоа се вика "BlackJack".
На пример: 
![image](https://user-images.githubusercontent.com/58054308/187400610-fe2b3b7c-7e7d-493c-9bd7-9d3095d65955.png)

## Како работи кодот:
Има два фајла од кои еден е `Card.cs`, а другиот е `Blackjack.cs`.

`Card.cs` каде што ќе се запишуваат картите за самата игра
```
public class Card
    {
        public string Name { get; set; }

        public int Value { get; set; }

        public string Image { get; set; }

        public Card(string name, int value, string image)
        {
            Name = name;
            Value = value;
            Image = image;
        }
    }
```

`Blackjack.cs` каде што се наоѓа главниот код за играта

На почетокот во овој фајл иницијализираме две листи во кои ке се чуваат картите на играчот и на компјутерот
```
        List<Card> PlayerCards = new List<Card>()
        {
            new Card(null,0,null)
        };

        List<Card> ComputerCards = new List<Card>()
        {
            new Card(null,0,null)
        };
```
Исто така иницијализираме и еден deck од сите карти

```
List<Card> deck = new List<Card>()
        {
            new Card("Two Clubs", 2, "CardsPictures/Clubs/2C.png"),
            new Card("Three Clubs", 3, "CardsPictures/Clubs/3C.png"),
            new Card("Four Clubs", 4, "CardsPictures/Clubs/4C.png"),
            new Card("Five Clubs", 5, "CardsPictures/Clubs/5C.png"),
            new Card("Six Clubs", 6, "CardsPictures/Clubs/6C.png"),
            ...
            ...
            ...
            new Card("Queen Spades", 10, "CardsPictures/Spades/QS.png"),
            new Card("King Spades", 10, "CardsPictures/Spades/KS.png"),
            new Card("Ace Spades", 11, "CardsPictures/Spades/AS.png")
        };
```

За почеток иницијализирани се и следниве податоци
```
        int bet = 200;
        int playercardSum = 0;
        int computercardSum = 0;
        Random random = new Random();
        List<int> used = new List<int>();
        List<int> cardUsed = new List<int>();
        List<PictureBox> playerPictureBox = new List<PictureBox>();
        List<PictureBox> computerPictureBox = new List<PictureBox>();
```

При клик на копчето Start се извршува следново
```
private void btnStart_Click(object sender, EventArgs e)
        {
            if (playercardSum > 0)
            {
                lblResult.Text = "The game is already started";
            }
            else if(int.Parse(lblBalance.Text) < bet)
            {
                lblResult.Text = "You can't bet more than you have";

            }
            else
            {
                lblMinusBet.Enabled = false;
                lblPlusBet.Enabled = false;
                lblMax.Enabled = false;
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
```

При клик на копчето Hit се извршува следново
```
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
```

При клик на копчето Stand се извршува следново
```
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
```

При клик на копчето Reset се случува следново
```
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

            lblMinusBet.Enabled = true;
            lblPlusBet.Enabled = true;
            lblMax.Enabled = true;
        }

        public void fullReset()
        {
            reset();

            lblBalance.Text = "1000";
        }
```

За менување на влогот се користат овие три функции
```
        private void lblPlusBet_Click(object sender, EventArgs e) // Za zgolemuvanje
        {
            bet += 100;
            lblBet.Text = "" + bet;
            if (bet > int.Parse(lblBalance.Text))
            {
                bet = int.Parse(lblBalance.Text);
                lblBet.Text = "" + bet;
            }
        }
        
        private void lblMinusBet_Click(object sender, EventArgs e) // Za namaluvanje
        {
            bet -= 100;
            lblBet.Text = "" + bet;
            if(int.Parse(lblBet.Text) < 0)
            {
                bet = 0;
                lblBet.Text = "0"; 
            }
        }

        private void lblMax_Click(object sender, EventArgs e) // Za Max bet
        {
            bet = int.Parse(lblBalance.Text);
            lblBet.Text = "" + bet;
        }
```

Останати функции кои се користат за да работи играта
```
        public int selectCard() // Za selektiranje na karta
        {
            int card;
            do
            {
                card = random.Next(0, deck.Count);
            } while (cardUsed.Contains(card));

            cardUsed.Add(card);

            return card;
        }

        private void sumPlayer() // Za suma od kartite na igracot
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

        private void sumComputer() // Za suma od kartite na kompjuterot
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

        private void displayBackCard(PictureBox picturebox) // Za da se skrijat nepokazani karti
        {
            picturebox.ImageLocation = "backOfCard.png";
            picturebox.SizeMode = PictureBoxSizeMode.AutoSize;
        }

```
