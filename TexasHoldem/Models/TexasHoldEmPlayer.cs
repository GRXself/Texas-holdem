using System;

namespace TexasHoldEm.Models
{
    public class TexasHoldEmPlayer
    {
        public string Name { get; set; }
        public HandCards HandCards { get; set; }

        public TexasHoldEmPlayer(string name)
        {
            Name = name;
        }
    }
}