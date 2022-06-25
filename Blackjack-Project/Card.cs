using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Project
{
    public class Card
    {
        public string Name { get; set; }

        public int Value { get; set; }

        public string Image { get; set; }

        public Card(string name, int value, string image)
        {
            Name = name;
            Value = value;
            Image = image;
        }
    }
}
