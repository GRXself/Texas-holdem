using System.Collections.Generic;
using TexasHoldEm.Core;
using TexasHoldEm.Level.Comparer;
using TexasHoldEm.Level.Condition;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level
{
    public class TwoPairsLevel : TexasHoldEmHandCardLevel
    {
        protected override void Initializer()
        {
            Name = "two pairs";
            Value = (int) TexasHoldEmHandCardLevelOrder.TwoPairs;
        }

        public override bool IsThisLevel(List<PokerCard> cards)
        {
            return new TwoPairsConditionChecker().IsThisCondition(cards);
        }

        public override void SameLevelCompare(TexasHoldEmPlayer blackPlayer, TexasHoldEmPlayer whitePlayer, TexasGameResult texasGameResult)
        {
            new PairConditionComparer().GetCompareResult(blackPlayer, whitePlayer, texasGameResult);
        }
    }
}