namespace TexasHoldem.Models
{
    public class HandCard
    {
        public int Level { get; set;}
        
        public string[] Cards { get; set; }

        public int[] CardValues { get; set; }
    }
}