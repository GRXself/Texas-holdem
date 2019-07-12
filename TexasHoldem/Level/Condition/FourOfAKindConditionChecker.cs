using System.Collections.Generic;
using TexasHoldEm.Level.Condition.Helper;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level.Condition
{
    public class FourOfAKindConditionChecker : IHandCardsConditionChecker
    {
        public bool IsThisCondition(IReadOnlyList<PokerCard> cards)
        {
            return HandCardsMaxSameCountHelper.GetHandCardsMaxSameCount(cards).Equals(4);
        }
    }
}