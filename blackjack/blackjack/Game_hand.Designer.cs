namespace blackjack
{
    partial class Game_hand
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
            this.button_hit = new System.Windows.Forms.Button();
            this.button_stay = new System.Windows.Forms.Button();
            this.label_player_hand_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_bet = new System.Windows.Forms.Label();
            this.button_test = new System.Windows.Forms.Button();
            this.listBox_player_hand = new System.Windows.Forms.ListBox();
            this.listBox_dealer_hand = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_dealer_hand_total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_hit
            // 
            this.button_hit.Location = new System.Drawing.Point(28, 71);
            this.button_hit.Name = "button_hit";
            this.button_hit.Size = new System.Drawing.Size(75, 23);
            this.button_hit.TabIndex = 1;
            this.button_hit.Text = "Hit";
            this.button_hit.UseVisualStyleBackColor = true;
            this.button_hit.Click += new System.EventHandler(this.Button_hit_Click);
            // 
            // button_stay
            // 
            this.button_stay.Location = new System.Drawing.Point(28, 100);
            this.button_stay.Name = "button_stay";
            this.button_stay.Size = new System.Drawing.Size(75, 23);
            this.button_stay.TabIndex = 2;
            this.button_stay.Text = "Stay";
            this.button_stay.UseVisualStyleBackColor = true;
            this.button_stay.Click += new System.EventHandler(this.Button_stay_Click);
            // 
            // label_player_hand_total
            // 
            this.label_player_hand_total.AutoSize = true;
            this.label_player_hand_total.Location = new System.Drawing.Point(133, 243);
            this.label_player_hand_total.Name = "label_player_hand_total";
            this.label_player_hand_total.Size = new System.Drawing.Size(63, 13);
            this.label_player_hand_total.TabIndex = 3;
            this.label_player_hand_total.Text = "Hand Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your Hand";
            // 
            // label_bet
            // 
            this.label_bet.AutoSize = true;
            this.label_bet.Location = new System.Drawing.Point(25, 138);
            this.label_bet.Name = "label_bet";
            this.label_bet.Size = new System.Drawing.Size(64, 13);
            this.label_bet.TabIndex = 5;
            this.label_bet.Text = "Bet amount:";
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(546, 290);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(75, 23);
            this.button_test.TabIndex = 6;
            this.button_test.Text = "testing";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.Button_test_Click);
            // 
            // listBox_player_hand
            // 
            this.listBox_player_hand.FormattingEnabled = true;
            this.listBox_player_hand.Location = new System.Drawing.Point(136, 71);
            this.listBox_player_hand.Name = "listBox_player_hand";
            this.listBox_player_hand.Size = new System.Drawing.Size(154, 160);
            this.listBox_player_hand.TabIndex = 7;
            // 
            // listBox_dealer_hand
            // 
            this.listBox_dealer_hand.FormattingEnabled = true;
            this.listBox_dealer_hand.Location = new System.Drawing.Point(484, 71);
            this.listBox_dealer_hand.Name = "listBox_dealer_hand";
            this.listBox_dealer_hand.Size = new System.Drawing.Size(154, 160);
            this.listBox_dealer_hand.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dealer Hand";
            // 
            // label_dealer_hand_total
            // 
            this.label_dealer_hand_total.AutoSize = true;
            this.label_dealer_hand_total.Location = new System.Drawing.Point(481, 243);
            this.label_dealer_hand_total.Name = "label_dealer_hand_total";
            this.label_dealer_hand_total.Size = new System.Drawing.Size(77, 13);
            this.label_dealer_hand_total.TabIndex = 10;
            this.label_dealer_hand_total.Text = "Dealer Total: ?";
            // 
            // Game_hand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_dealer_hand_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_dealer_hand);
            this.Controls.Add(this.listBox_player_hand);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.label_bet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_player_hand_total);
            this.Controls.Add(this.button_stay);
            this.Controls.Add(this.button_hit);
            this.Name = "Game_hand";
            this.Text = "Blackjack Hand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_hit;
        private System.Windows.Forms.Button button_stay;
        private System.Windows.Forms.Label label_player_hand_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_bet;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.ListBox listBox_player_hand;
        private System.Windows.Forms.ListBox listBox_dealer_hand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_dealer_hand_total;
    }
}

