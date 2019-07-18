using System.Collections.Generic;
using System.Linq;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level.Condition
{
    public class StraightConditionChecker : IHandCardsConditionChecker
    {
        public bool IsThisCondition(List<PokerCard> cards)
        {
            return cards.All(c => c.Value - cards.IndexOf(c) == cards.FirstOrDefault().Value);
        }
    }
}