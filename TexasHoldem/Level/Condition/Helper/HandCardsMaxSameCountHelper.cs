using System.Collections.Generic;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level.Condition.Helper
{
    public static class HandCardsMaxSameCountHelper
    {
        public static int GetHandCardsMaxSameCount(IReadOnlyList<PokerCard> cards)
        {
            var maxSameCount = 1;
            var currentSameCount = 1;
            var currentSameNumber = cards[0];
            for (var i = 1; i < cards.Count; i++)
            {
                if (currentSameNumber.CompareTo(cards[i]).Equals(0))
                {
                    currentSameCount++;
                }
                else
                {
                    currentSameNumber = cards[i];
                    maxSameCount = maxSameCount > currentSameCount ? maxSameCount : currentSameCount;
                    currentSameCount = 1;
                }
            }
            return maxSameCount > currentSameCount ? maxSameCount : currentSameCount;
        }
    }
}