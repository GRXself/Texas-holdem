namespace TexasHoldEm.Models
{
    public class TexasHoldEmPlayer
    {
        public string Name { get; }
        public HandCards HandCards { get; set; }

        public TexasHoldEmPlayer(string name)
        {
            Name = name;
        }
    }
}