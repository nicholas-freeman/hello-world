namespace blackjack
{
    partial class Game_start
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_new_hand = new System.Windows.Forms.Button();
            this.button_manage_money = new System.Windows.Forms.Button();
            this.label_money = new System.Windows.Forms.Label();
            this.button_rules = new System.Windows.Forms.Button();
            this.textBox_balance = new System.Windows.Forms.TextBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to blackjack";
            // 
            // button_new_hand
            // 
            this.button_new_hand.Location = new System.Drawing.Point(336, 325);
            this.button_new_hand.Name = "button_new_hand";
            this.button_new_hand.Size = new System.Drawing.Size(110, 59);
            this.button_new_hand.TabIndex = 1;
            this.button_new_hand.Text = "New Hand";
            this.button_new_hand.UseVisualStyleBackColor = true;
            this.button_new_hand.Click += new System.EventHandler(this.Button_new_hand_Click);
            // 
            // button_manage_money
            // 
            this.button_manage_money.Location = new System.Drawing.Point(12, 174);
            this.button_manage_money.Name = "button_manage_money";
            this.button_manage_money.Size = new System.Drawing.Size(104, 35);
            this.button_manage_money.TabIndex = 2;
            this.button_manage_money.Text = "Set Balance";
            this.button_manage_money.UseVisualStyleBackColor = true;
            this.button_manage_money.Click += new System.EventHandler(this.Button_manage_money_Click);
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.Location = new System.Drawing.Point(9, 132);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(58, 13);
            this.label_money.TabIndex = 3;
            this.label_money.Text = "Balance: 0";
            // 
            // button_rules
            // 
            this.button_rules.Location = new System.Drawing.Point(12, 244);
            this.button_rules.Name = "button_rules";
            this.button_rules.Size = new System.Drawing.Size(104, 35);
            this.button_rules.TabIndex = 4;
            this.button_rules.Text = "Blackjack Rules";
            this.button_rules.UseVisualStyleBackColor = true;
            this.button_rules.Click += new System.EventHandler(this.Button_rules_Click);
            // 
            // textBox_balance
            // 
            this.textBox_balance.Location = new System.Drawing.Point(12, 148);
            this.textBox_balance.Name = "textBox_balance";
            this.textBox_balance.Size = new System.Drawing.Size(104, 20);
            this.textBox_balance.TabIndex = 5;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(678, 388);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(110, 50);
            this.button_exit.TabIndex = 6;
            this.button_exit.Text = "Save and Quit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // Game_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.textBox_balance);
            this.Controls.Add(this.button_rules);
            this.Controls.Add(this.label_money);
            this.Controls.Add(this.button_manage_money);
            this.Controls.Add(this.button_new_hand);
            this.Controls.Add(this.label1);
            this.Name = "Game_start";
            this.Text = "Blackjack Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_new_hand;
        private System.Windows.Forms.Button button_manage_money;
        private System.Windows.Forms.Label label_money;
        private System.Windows.Forms.Button button_rules;
        private System.Windows.Forms.TextBox textBox_balance;
        private System.Windows.Forms.Button button_exit;
    }
}