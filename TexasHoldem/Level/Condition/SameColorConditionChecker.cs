using System.Collections.Generic;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level.Condition
{
    public class SameColorConditionChecker : IHandCardsConditionChecker
    {
        public bool IsThisCondition(IReadOnlyList<PokerCard> cards)
        {
            for (var i = 0; i < cards.Count - 1; i++)
            {
                if (!cards[i].IsSameColor(cards[i + 1]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}