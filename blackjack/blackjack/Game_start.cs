using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace blackjack
{
    public partial class Game_start : Form
    {
        private int player_balance;
        private readonly string MONEY_MSG = "Balance: ";
        public Game_start()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("balance_storage.txt");
            player_balance = Int32.Parse(sr.ReadToEnd());
            sr.Close();
            label_money.Text = MONEY_MSG + player_balance.ToString();

        }
        ~Game_start()
        {
            //destructor - store balance

        }
        private void Button_new_hand_Click(object sender, EventArgs e)
        {
            Bet_input bet = new Bet_input(player_balance);
            this.Hide();
            bet.ShowDialog();
            player_balance += bet.Get_balance_change();
            this.Show();
            label_money.Text = MONEY_MSG + player_balance.ToString();
        }

        private void Button_manage_money_Click(object sender, EventArgs e)
        {
            int tmp = -1;
            try
            {
                tmp = Int32.Parse(textBox_balance.Text);
            }
            catch
            {
                //MessageBox.Show("Input must be a positive integer");
                tmp = -1;
            }
            if (tmp < 0 )
            {
                //don't change
                MessageBox.Show("Input must be a positive integer");
            }
            else
            {
                //valid input
                player_balance = tmp;
            }
            textBox_balance.Text = "";
            label_money.Text = MONEY_MSG + player_balance.ToString();
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("balance_storage.txt", false);
            sw.Write(player_balance);
            sw.Close();
            this.Close();
        }

        private void Button_rules_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bicyclecards.com/how-to-play/blackjack/");
        }
    }
}
