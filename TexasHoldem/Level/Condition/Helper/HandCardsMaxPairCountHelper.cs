using System.Collections.Generic;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level.Condition.Helper
{
    public static class HandCardsMaxPairCountHelper
    {
        public static int GetHandCardsMaxPairCount(IReadOnlyList<PokerCard> cards)
        {
            return GetPairCount(cards);
        }

        private static int GetPairCount(IReadOnlyList<PokerCard> cards)
        {
            var pairCount = 0;
            var currentPairCard = cards[0];
            for (var i = 1; i < cards.Count; i++)
            {
                if (currentPairCard.CompareTo(cards[i]).Equals(0))
                {
                    if (i + 1 < cards.Count)
                    {
                        if (!currentPairCard.CompareTo(cards[i + 1]).Equals(0))
                        {
                            pairCount++;
                        }
                        currentPairCard = cards[i + 1];
                    }
                    else
                    {
                        pairCount++;
                    }

                    i += 1;
                }
                else
                {
                    currentPairCard = cards[i];
                }
            }
            return pairCount;
        }
    }
}