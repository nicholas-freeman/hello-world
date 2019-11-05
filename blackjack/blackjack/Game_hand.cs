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
    public partial class Game_hand : Form
    {
        private readonly int BUST_LIMIT = -1; //-1 used to indicate bust
        private readonly int DEALER_LIMIT = 17;
        private readonly string BUST_MSG = "BUST";
        private readonly string PTOTAL = "Hand total: ";
        private readonly string DTOTAL = "Dealer total: ";
        private readonly string HIDDEN = "Facedown card";
        private readonly string BET_MSG = "Bet amount: ";
        private int bet;
        Deck game_deck = new Deck();
        Computer_dealer dealer = new Computer_dealer();
        Human_player player = new Human_player();
        public Game_hand( int betval )
        {
            InitializeComponent();
            this.bet = betval;
            //start with 2 cards each
            player.Human_hit(game_deck);
            listBox_player_hand.Items.Add(player.Get_last_name());
            player.Human_hit(game_deck);
            listBox_player_hand.Items.Add(player.Get_last_name());
            label_player_hand_total.Text = PTOTAL + player.Get_hand_val().ToString();
            //fill list box with a function
            dealer.Dealer_hit(game_deck);
            listBox_dealer_hand.Items.Add(HIDDEN);
            dealer.Dealer_hit(game_deck);
            listBox_dealer_hand.Items.Add(dealer.Get_last_name());
            label_bet.Text = BET_MSG + bet.ToString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_test_Click(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i < 48; i++)
            {
                MessageBox.Show(game_deck.get_deck()[i].get_name() + game_deck.get_deck()[i].get_value().ToString());
            }
        }

        private void Button_hit_Click(object sender, EventArgs e)
        {
            if( player.Get_hand_val() != BUST_LIMIT )
            {
                player.Human_hit(game_deck);
                listBox_player_hand.Items.Add(player.Get_last_name());
                if( player.Get_hand_val() != BUST_LIMIT )
                {
                    label_player_hand_total.Text = PTOTAL + player.Get_hand_val().ToString();
                }
                else
                {
                    label_player_hand_total.Text = PTOTAL + BUST_MSG;
                    //activate stay - determines winner
                    Button_stay_Click(new object(), new EventArgs());
                }
            }
        }

        private void Button_stay_Click(object sender, EventArgs e)
        {
            //reveal hidden card
            listBox_dealer_hand.Items.RemoveAt(0);
            listBox_dealer_hand.Items.Insert(0, dealer.Get_first_card());
            //do dealer hits if player didn't bust
            if (player.Get_hand_val() != -1)
            {
                while (dealer.get_hand_val() < DEALER_LIMIT && dealer.get_hand_val() != -1)
                {
                    dealer.Dealer_hit(game_deck);
                    //add dealer hits to listbox
                    listBox_dealer_hand.Items.Add(dealer.Get_last_name());
                }

            }
            if ( dealer.get_hand_val() == -1 )
                label_dealer_hand_total.Text = DTOTAL + BUST_MSG;
            else
                label_dealer_hand_total.Text = DTOTAL + dealer.get_hand_val().ToString();
            //check who won
            if ( dealer.get_hand_val() == player.Get_hand_val() )
            {
                //push - both bust not possible
                MessageBox.Show("Draw - all bets returned");
                bet = 0;
            }
            else if ( player.Get_hand_val() == -1 )
            {
                //dealer win
                MessageBox.Show("You busted - dealer wins");
                bet = bet * -1;
            }
            else if ( player.Get_hand_val() < dealer.get_hand_val() )
            {
                //dealer win
                MessageBox.Show("Dealer wins");
                bet = bet * -1;
            }
            else if ( dealer.get_hand_val() == -1 )
            {
                //player win
                MessageBox.Show("Dealer busted - player wins");
                //bet stays same
            }
            else
            {
                MessageBox.Show("Player wins");
                //bet stays same
            }
            //hand over - go back to main menu
            this.Hide();
        }
        public int Get_change()
        {
            return bet;
        }
    }
}
