using System.Collections.Generic;
using TexasHoldEm.Core;
using TexasHoldEm.Level.Comparer;
using TexasHoldEm.Level.Condition;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level
{
    public class StraightFlushLevel : TexasHoldEmHandCardLevel
    {
        protected override void Initializer()
        {
            Name = "straight flush";
            Value = (int) TexasHoldEmHandCardLevelOrder.StraightFlush;
        }

        public override bool IsThisLevel(List<PokerCard> cards)
        {
            return new SameColorConditionChecker().IsThisCondition(cards) &&
                   new StraightConditionChecker().IsThisCondition(cards);
        }

        public override void SameLevelCompare(TexasHoldEmPlayer blackPlayer, TexasHoldEmPlayer whitePlayer, TexasGameResult texasGameResult)
        {
            new HighCardConditionComparer().GetCompareResult(blackPlayer, whitePlayer, texasGameResult);
        }
    }
}