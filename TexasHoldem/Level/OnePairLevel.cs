using System.Collections.Generic;
using TexasHoldEm.Core;
using TexasHoldEm.Level.Comparer;
using TexasHoldEm.Level.Condition;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level
{
    public class OnePairLevel : TexasHoldEmHandCardLevel
    {
        protected override void Initializer()
        {
            Name = "pair";
            Value = (int) TexasHoldEmHandCardLevelOrder.Pair;
        }

        public override bool IsThisLevel(List<PokerCard> cards)
        {
            return new OnePairConditionChecker().IsThisCondition(cards) &&
                   !new ThreeOfAKindConditionChecker().IsThisCondition(cards);
        }

        public override TexasGameResult GetSameLevelCompareResult(TexasHoldEmPlayer blackPlayer,
            TexasHoldEmPlayer whitePlayer)
        {
            return new PairConditionComparer().GetCompareResult(blackPlayer, whitePlayer);
        }
    }
}