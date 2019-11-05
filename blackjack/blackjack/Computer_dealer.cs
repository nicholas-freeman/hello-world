using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Computer_dealer : Player
    {
        private int hand_total = 0;
        public Computer_dealer()
        {
            //constructor
        }
        public void Dealer_hit(Deck deck)
        {
            int tmp;
            if (hand_total != -1)
            {
                tmp = Hit(deck);
                if (tmp == 11 )
                {
                    if (tmp + hand_total > 21)
                        tmp = 1;
                }

                hand_total += tmp;
            }

            if (hand_total > 21)
                hand_total = -1;
               
        }
        public int get_hand_val()
        {
            return hand_total;
        }
    }
}
