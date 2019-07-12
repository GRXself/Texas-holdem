using System.Collections.Generic;
using TexasHoldEm.Level.Condition.Helper;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level.Condition
{
    public class HighCardConditionChecker : IHandCardsConditionChecker
    {
        public bool IsThisCondition(IReadOnlyList<PokerCard> cards)
        {
            return !new StraightConditionChecker().IsThisCondition(cards) &&
                   !new SameColorConditionChecker().IsThisCondition(cards) &&
                   HandCardsMaxSameCountHelper.GetHandCardsMaxSameCount(cards).Equals(1);
        }
    }
}