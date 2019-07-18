using System.Collections.Generic;
using TexasHoldEm.Core;
using TexasHoldEm.Level.Comparer;
using TexasHoldEm.Level.Condition;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level
{
    public class HighCardLevel : TexasHoldEmHandCardLevel
    {
        protected override void Initializer()
        {
            Name = "high card";
            Value = (int) TexasHoldEmHandCardLevelOrder.HighCard;
        }

        public override bool IsThisLevel(List<PokerCard> cards)
        {
            return new HighCardConditionChecker().IsThisCondition(cards);
        }

        public override TexasGameResult GetSameLevelCompareResult(TexasHoldEmPlayer blackPlayer,
            TexasHoldEmPlayer whitePlayer)
        {
            return new HighCardConditionComparer().GetCompareResult(blackPlayer, whitePlayer);
        }
    }
}