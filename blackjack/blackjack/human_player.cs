using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    public class Human_player : Player
    {
        private int hand_total;
        public Human_player()
        {
            hand_total = 0;
        }

        public int Human_hit(Deck deck)
        {
            int tmp = Hit(deck);
            if (tmp == 11)
            {
                //if ace 11 busts
                if (tmp + hand_total > 21)
                    tmp = 1;
            }
            hand_total += tmp;

            if (hand_total > bust_limit)
                hand_total = -1;

            return hand_total;
        }
        public int Get_hand_val()
        {
            return hand_total;
        }
    }
}
