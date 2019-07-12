using System.Collections.Generic;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level.Comparer
{
    public class MiddleCardConditionComparer : IHandCardsComparer
    {
        public void GetCompareResult(
            TexasHoldEmPlayer blackPlayer, 
            TexasHoldEmPlayer whitePlayer,
            TexasGameResult texasGameResult)
        {
            const int middleValueIndex = 2;
            
            var blackPlayerMiddleCard = blackPlayer.HandCards.Cards[middleValueIndex];
            var whitePlayerMiddleCard = whitePlayer.HandCards.Cards[middleValueIndex];
            
            var compareResult = blackPlayerMiddleCard.CompareTo(whitePlayerMiddleCard);
            if (compareResult > 0)
            {
                texasGameResult.WinnerName = blackPlayer.Name;
                texasGameResult.WinCard = blackPlayerMiddleCard.ToCardValueString();
            }
            else
            {
                texasGameResult.WinnerName = whitePlayer.Name;
                texasGameResult.WinCard = whitePlayerMiddleCard.ToCardValueString();
            }
        }
    }
}