using System.Collections.Generic;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level.Condition
{
    public interface IHandCardsConditionChecker
    {
        bool IsThisCondition(IReadOnlyList<PokerCard> cards);
    }
}