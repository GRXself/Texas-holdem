using System.Collections.Generic;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level.Comparer
{
    public interface IHandCardsComparer
    {
        void GetCompareResult(
            TexasHoldEmPlayer blackPlayer, 
            TexasHoldEmPlayer whitePlayer,
            TexasGameResult texasGameResult);
    }
}