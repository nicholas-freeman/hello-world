using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack
{

    public partial class Bet_input : Form
    {
        private int bet = 0;
        private int value_change = 0;
        private int balance;
        public Bet_input( int bal )
        {
            balance = bal;
            InitializeComponent();
        }

        private void Button_enter_Click(object sender, EventArgs e )
        {
            try
            {
                //if int -> read into i
                bet = Int32.Parse(textBox_amount.Text);
            }
            catch
            {
                //input not integer -> set to negative integer for easy check
                bet = -1;
            }
            if( bet < 0 || bet > balance ) //checks if negative input or non-integer (catch sets to -1)
            {
                MessageBox.Show("Input must be a positive integer and less than or equal to your balance (" + balance + ")");
            }
            else
            {
                //make a game with the bet value
                Game_hand hand = new Game_hand(bet);
                this.Hide();
                hand.ShowDialog();
                value_change = hand.Get_change();
            }
        }

        public int Get_bet_val()
        {
            return bet;
        }
        public int Get_balance_change()
        {
            return value_change;
        }
    }
}
