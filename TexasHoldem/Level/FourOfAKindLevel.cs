using System.Collections.Generic;
using TexasHoldEm.Core;
using TexasHoldEm.Level.Comparer;
using TexasHoldEm.Level.Condition;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level
{
    public class FourOfAKindLevel : TexasHoldEmHandCardLevel
    {
        protected override void Initializer()
        {
            Name = "four of a kind";
            Value = (int) TexasHoldEmHandCardLevelOrder.FourOfAKind;
        }

        public override bool IsThisLevel(List<PokerCard> cards)
        {
            return new FourOfAKindConditionChecker().IsThisCondition(cards);
        }

        public override TexasGameResult GetSameLevelCompareResult(TexasHoldEmPlayer blackPlayer,
            TexasHoldEmPlayer whitePlayer)
        {
            return new MiddleCardConditionComparer().GetCompareResult(blackPlayer, whitePlayer);
        }
    }
}