using System.Collections.Generic;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level.Comparer
{
    public class PairConditionComparer : IHandCardsComparer
    {
        public void GetCompareResult(
            TexasHoldEmPlayer blackPlayer, 
            TexasHoldEmPlayer whitePlayer, 
            TexasGameResult texasGameResult)
        {
            var blackPlayerHandCards = blackPlayer.HandCards.Cards;
            var whitePlayerHandCards = whitePlayer.HandCards.Cards;

            var blackPlayerPairCards = GetPairCards(blackPlayerHandCards);
            var whitePlayerPairCards = GetPairCards(whitePlayerHandCards);

            for (var i = blackPlayerPairCards.Count - 1; i > -1; i--)
            {
                var compareResult = blackPlayerPairCards[i].CompareTo(whitePlayerPairCards[i]);
                if (compareResult > 0)
                {
                    texasGameResult.WinnerName = blackPlayer.Name;
                    texasGameResult.WinCard = blackPlayerPairCards[i].ToCardValueString();
                }
                else if (compareResult < 0)
                {
                    texasGameResult.WinnerName = whitePlayer.Name;
                    texasGameResult.WinCard = whitePlayerPairCards[i].ToCardValueString();
                }
            }

            if (string.IsNullOrEmpty(texasGameResult.WinnerName))
            {
                new HighCardConditionComparer().GetCompareResult(
                    blackPlayer, whitePlayer, texasGameResult);
            }
        }

        private static List<PokerCard> GetPairCards(IReadOnlyList<PokerCard> cards)
        {
            var pairsResult = new List<PokerCard>();
            var currentPairCard = cards[0];
            for (var i = 1; i < cards.Count; i++)
            {
                if (currentPairCard.CompareTo(cards[i]).Equals(0))
                {
                    pairsResult.Add(currentPairCard);
                    i++;
                }
                else
                {
                    currentPairCard = cards[i];
                }
            }

            return pairsResult;
        }
    }
}