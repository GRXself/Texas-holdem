using TexasHoldEm.Models;

namespace TexasHoldEm.Level.Comparer
{
    public interface IHandCardsComparer
    {
        TexasGameResult GetCompareResult(
            TexasHoldEmPlayer blackPlayer,
            TexasHoldEmPlayer whitePlayer);
    }
}