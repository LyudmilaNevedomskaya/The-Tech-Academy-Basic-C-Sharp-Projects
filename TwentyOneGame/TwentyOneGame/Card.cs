using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Card
    {
        public Card()
        {
            Suit = "Spades";
            Face = "two";
        }
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
