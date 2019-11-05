using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    public class Card
    {
        private readonly int value;
        private readonly string name;
        public Card(int v, string n)
        {
            value = v;
            name = n;
        }

        public int get_value()
        {
            return value;
        }
        public string get_name()
        {
            return name;
        }
    }
}
