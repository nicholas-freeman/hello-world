using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    public class Player
    {
        private List<Card> cards_in_hand;
        public readonly int bust_limit = 21;
        public Player()
        {
            cards_in_hand = new List<Card>();
            //do nothing
        }
        //draw_card
        public int Hit(Deck deck)
        {
            cards_in_hand.Add(deck.deal());

            return cards_in_hand[cards_in_hand.Count()-1].get_value();
        }

        public string Get_last_name()
        {
            //return name of most recent card added
            return cards_in_hand[cards_in_hand.Count()-1].get_name(); 
        }
        public string Get_first_card()
        {
            return cards_in_hand[0].get_name();
        }
        
    }
}
