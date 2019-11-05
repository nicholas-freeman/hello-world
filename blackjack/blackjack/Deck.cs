using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    public class Deck
    {
        private List<Card> deck;
        private int cards_left;
        private static List<string> suits;
        private readonly int face_value = 10;
        private Random rnd;
        public Deck()
        {
            suits = new List<string>();
            deck = new List<Card>();
            this.cards_left = 52;
            rnd = new Random();

            suits.Add("_Spades");
            suits.Add("_Clubs");
            suits.Add("_Diamonds");
            suits.Add("_Hearts");
            for ( int i = 1; i <= 10; i++ )
            {
                //handle Ace as a special case in score calculation
                for (int k = 0; k < 4; k++ )
                {
                    if (i == 1)
                    {
                        Card tmp = new Card(11, "A" + suits[k]);
                        deck.Add(tmp);
                    }
                    else
                    {
                        Card tmp = new Card(i, i.ToString() + suits[k]);
                        deck.Add(tmp);
                    }
                }
            }
            //face cards
            for (int k = 0; k < 4; k++)
            {
                Card tmp = new Card(face_value, "J" + suits[k]);
                deck.Add(tmp);
            }
            for (int k = 0; k < 4; k++)
            {
                Card tmp = new Card(face_value, "Q" + suits[k]);
                deck.Add(tmp);
            }
            for (int k = 0; k < 4; k++)
            {
                Card tmp = new Card(face_value, "K" + suits[k]);
                deck.Add(tmp);
            }
        }
        public List<Card> get_deck()
        {
            return deck;
        }
        public Card deal()
        {
            if (cards_left > 0 )
            {
                //choose 0 - 51 for card
                int i = rnd.Next(0, cards_left-1);
                Card dealt_card = deck[i];
                //remove from deck list
                deck.RemoveAt(i);
                cards_left--;
                return dealt_card;
            }
            else
            {
                //proper error handling later
                Card dealt_card = deck[0];
                return dealt_card;
            }

        }
    }
}
