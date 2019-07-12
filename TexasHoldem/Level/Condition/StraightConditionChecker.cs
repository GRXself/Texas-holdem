using System.Collections.Generic;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level.Condition
{
    public class StraightConditionChecker : IHandCardsConditionChecker
    {
        public bool IsThisCondition(IReadOnlyList<PokerCard> cards)
        {
            for (var i = 0; i < cards.Count - 1; i++)
            {
                if (cards[i].Value != (cards[i + 1]).Value - 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}