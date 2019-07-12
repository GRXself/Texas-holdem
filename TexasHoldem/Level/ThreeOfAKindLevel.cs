using System.Collections.Generic;
using TexasHoldEm.Core;
using TexasHoldEm.Level.Comparer;
using TexasHoldEm.Level.Condition;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level
{
    public class ThreeOfAKindLevel : TexasHoldEmHandCardLevel
    {
        protected override void Initializer()
        {
            Name = "three of a kind";
            Value = (int) TexasHoldEmHandCardLevelOrder.ThreeOfAKind;
        }

        public override bool IsThisLevel(List<PokerCard> cards)
        {
            return new ThreeOfAKindConditionChecker().IsThisCondition(cards) &&
                   !new OnePairConditionChecker().IsThisCondition(cards);
        }

        public override void SameLevelCompare(TexasHoldEmPlayer blackPlayer, TexasHoldEmPlayer whitePlayer, TexasGameResult texasGameResult)
        {
            new MiddleCardConditionComparer().GetCompareResult(blackPlayer, whitePlayer, texasGameResult);
        }
    }
}