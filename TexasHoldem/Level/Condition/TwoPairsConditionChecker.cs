using System.Collections.Generic;
using TexasHoldEm.Level.Condition.Helper;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level.Condition
{
    public class TwoPairsConditionChecker : IHandCardsConditionChecker
    {
        public bool IsThisCondition(List<PokerCard> cards)
        {
            return HandCardsMaxPairCountHelper.GetHandCardsMaxPairCount(cards).Equals(2);
        }
    }
}