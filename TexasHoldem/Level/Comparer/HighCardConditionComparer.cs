using TexasHoldEm.Models;

namespace TexasHoldEm.Level.Comparer
{
    public class HighCardConditionComparer : IHandCardsComparer
    {
        public void GetCompareResult(
            TexasHoldEmPlayer blackPlayer, 
            TexasHoldEmPlayer whitePlayer,
            TexasGameResult texasGameResult)
        {
            var blackPlayerHandCards = blackPlayer.HandCards.Cards;
            var whitePlayerHandCards = whitePlayer.HandCards.Cards;
            
            for (var i = blackPlayerHandCards.Count - 1; i > -1; i--)
            {
                var compareResult = blackPlayerHandCards[i].CompareTo(whitePlayerHandCards[i]);
                if (compareResult > 0)
                {
                    texasGameResult.WinnerName = blackPlayer.Name;
                    texasGameResult.WinCard = blackPlayerHandCards[i].ToCardValueString();
                    return;
                }
                if (compareResult < 0)
                {
                    texasGameResult.WinnerName = whitePlayer.Name;
                    texasGameResult.WinCard = whitePlayerHandCards[i].ToCardValueString();
                    return;
                }
            }

            texasGameResult.IsTie = true;
        }
    }
}