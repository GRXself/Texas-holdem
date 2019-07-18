using System.Collections.Generic;
using TexasHoldEm.Core;
using TexasHoldEm.Level.Comparer;
using TexasHoldEm.Level.Condition;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level
{
    public class FullHouseLevel : TexasHoldEmHandCardLevel
    {
        protected override void Initializer()
        {
            Name = "full house";
            Value = (int) TexasHoldEmHandCardLevelOrder.FullHouse;
        }

        public override bool IsThisLevel(List<PokerCard> cards)
        {
            return new ThreeOfAKindConditionChecker().IsThisCondition(cards) &&
                   new OnePairConditionChecker().IsThisCondition(cards);
        }

        public override TexasGameResult GetSameLevelCompareResult(TexasHoldEmPlayer blackPlayer,
            TexasHoldEmPlayer whitePlayer)
        {
            return new MiddleCardConditionComparer().GetCompareResult(blackPlayer, whitePlayer);
        }
    }
}