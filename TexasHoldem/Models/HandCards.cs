using System.Collections.Generic;
using System.Linq;
using TexasHoldEm.Level;

namespace TexasHoldEm.Models
{
    public class HandCards
    {
        public readonly List<PokerCard> Cards = new List<PokerCard>();

        public HandCards(string inputString)
        {
            var sourceCardStrings = inputString.Trim().Split(" ");
            foreach (var singleCardString in sourceCardStrings)
            {
                Cards.Add(new PokerCard(singleCardString));
            }

            Cards = Cards.OrderBy(c => c.Value).ToList();
        }

        public TexasHoldEmHandCardLevel GetHandCardsLevel()
        {
            TexasHoldEmHandCardLevel[] allLevels =
            {
                new StraightFlushLevel(), 
                new FourOfAKindLevel(),
                new FullHouseLevel(), 
                new FlushLevel(), 
                new StraightLevel(),
                new ThreeOfAKindLevel(), 
                new TwoPairsLevel(), 
                new OnePairLevel(), 
                new HighCardLevel() 
            };
            return allLevels.FirstOrDefault(currentLevel => currentLevel.IsThisLevel(Cards));
        }
    }
}