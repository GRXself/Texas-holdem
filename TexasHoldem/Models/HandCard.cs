using TexasHoldem.Core;

namespace TexasHoldem.Models
{
    public class HandCard
    {
        public Levels Level { get; set;}
        
        public string[] Cards { get; set; }

        public int[] CardValues { get; set; }
    }
}