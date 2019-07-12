using System.Collections.Generic;
using TexasHoldEm.Level.Condition.Helper;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level.Condition
{
    public class ThreeOfAKindConditionChecker : IHandCardsConditionChecker
    {
        public bool IsThisCondition(IReadOnlyList<PokerCard> cards)
        {
            return HandCardsMaxSameCountHelper.GetHandCardsMaxSameCount(cards).Equals(3);
        }
    }
}