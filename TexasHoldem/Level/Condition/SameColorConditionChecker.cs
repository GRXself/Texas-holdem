using System.Collections.Generic;
using System.Linq;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level.Condition
{
    public class SameColorConditionChecker : IHandCardsConditionChecker
    {
        public bool IsThisCondition(List<PokerCard> cards)
        {
            return cards.All(c => c.IsSameColor(cards.FirstOrDefault()));
        }
    }
}