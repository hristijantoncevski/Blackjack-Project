namespace Blackjack_Project
{
    partial class Blackjack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blackjack));
            this.pbFirstCard = new System.Windows.Forms.PictureBox();
            this.pbSecondCard = new System.Windows.Forms.PictureBox();
            this.pbComputerFirstCard = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblComputerCardsSum = new System.Windows.Forms.Label();
            this.lblPlayerCardsSum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerFirstCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFirstCard
            // 
            this.pbFirstCard.ImageLocation = "";
            this.pbFirstCard.Location = new System.Drawing.Point(219, 371);
            this.pbFirstCard.Name = "pbFirstCard";
            this.pbFirstCard.Size = new System.Drawing.Size(120, 180);
            this.pbFirstCard.TabIndex = 0;
            this.pbFirstCard.TabStop = false;
            // 
            // pbSecondCard
            // 
            this.pbSecondCard.Location = new System.Drawing.Point(345, 371);
            this.pbSecondCard.Name = "pbSecondCard";
            this.pbSecondCard.Size = new System.Drawing.Size(120, 180);
            this.pbSecondCard.TabIndex = 1;
            this.pbSecondCard.TabStop = false;
            // 
            // pbComputerFirstCard
            // 
            this.pbComputerFirstCard.Location = new System.Drawing.Point(219, 45);
            this.pbComputerFirstCard.Name = "pbComputerFirstCard";
            this.pbComputerFirstCard.Size = new System.Drawing.Size(120, 180);
            this.pbComputerFirstCard.TabIndex = 2;
            this.pbComputerFirstCard.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(701, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 89);
            this.label1.TabIndex = 4;
            this.label1.Text = "COMPUTER MUST DRAW TO 16 AND STAND ON 17 OR ABOVE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Computer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Player";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(30, 200);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(106, 43);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(30, 249);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(106, 43);
            this.btnHit.TabIndex = 8;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(30, 298);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(106, 43);
            this.btnStand.TabIndex = 9;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(30, 347);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 43);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(215, 259);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(401, 72);
            this.lblResult.TabIndex = 11;
            // 
            // lblComputerCardsSum
            // 
            this.lblComputerCardsSum.AutoSize = true;
            this.lblComputerCardsSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerCardsSum.Location = new System.Drawing.Point(135, 120);
            this.lblComputerCardsSum.Name = "lblComputerCardsSum";
            this.lblComputerCardsSum.Size = new System.Drawing.Size(18, 20);
            this.lblComputerCardsSum.TabIndex = 12;
            this.lblComputerCardsSum.Text = "0";
            // 
            // lblPlayerCardsSum
            // 
            this.lblPlayerCardsSum.AutoSize = true;
            this.lblPlayerCardsSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCardsSum.Location = new System.Drawing.Point(135, 450);
            this.lblPlayerCardsSum.Name = "lblPlayerCardsSum";
            this.lblPlayerCardsSum.Size = new System.Drawing.Size(18, 20);
            this.lblPlayerCardsSum.TabIndex = 13;
            this.lblPlayerCardsSum.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(827, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Balance:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(922, 553);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(23, 25);
            this.lblBalance.TabIndex = 15;
            this.lblBalance.Text = "0";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(701, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 54);
            this.label5.TabIndex = 16;
            this.label5.Text = "WIN PAYS 3 TO 2 BLACKJACK PAYS 2 TO 1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(664, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Bet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(717, 553);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "200";
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 587);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPlayerCardsSum);
            this.Controls.Add(this.lblComputerCardsSum);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbComputerFirstCard);
            this.Controls.Add(this.pbSecondCard);
            this.Controls.Add(this.pbFirstCard);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Blackjack";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerFirstCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFirstCard;
        private System.Windows.Forms.PictureBox pbSecondCard;
        private System.Windows.Forms.PictureBox pbComputerFirstCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblComputerCardsSum;
        private System.Windows.Forms.Label lblPlayerCardsSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

