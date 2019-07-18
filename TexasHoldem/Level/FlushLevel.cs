using System.Collections.Generic;
using TexasHoldEm.Core;
using TexasHoldEm.Level.Comparer;
using TexasHoldEm.Level.Condition;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level
{
    public class FlushLevel : TexasHoldEmHandCardLevel
    {
        protected override void Initializer()
        {
            Name = "flush";
            Value = (int)TexasHoldEmHandCardLevelOrder.Flush;
        }

        public override bool IsThisLevel(List<PokerCard> cards)
        {
            return new SameColorConditionChecker().IsThisCondition(cards) &&
                   !new StraightConditionChecker().IsThisCondition(cards);
        }

        public override TexasGameResult GetSameLevelCompareResult(TexasHoldEmPlayer blackPlayer,
            TexasHoldEmPlayer whitePlayer)
        {
            return new HighCardConditionComparer().GetCompareResult(blackPlayer, whitePlayer);
        }
    }
}