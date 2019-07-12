using TexasHoldEm.Comparer;
using TexasHoldEm.Models;
using TexasHoldEm.Tests.TestData;
using Xunit;

namespace TexasHoldEm.Tests.Comparer
{
    public class TexasGameComparerTests
    {
        private TexasGameComparer _comparer;

        public TexasGameComparerTests()
        {
            _comparer = new TexasGameComparer();
        }

        [Theory]
        [ClassData(typeof(TexasGameComparerTestData))]
        public void ReturnCompareResultGivenTwoReadyPlayers(
            TexasHoldEmPlayer blackPlayer, 
            TexasHoldEmPlayer whitePlayer,
            TexasGameResult expectedGameResult)
        {
            var compareResult = _comparer.CompareHandCards(blackPlayer, whitePlayer);
            Assert.Equal(expectedGameResult.IsTie, compareResult.IsTie);
            Assert.Equal(expectedGameResult.WinLevel, compareResult.WinLevel);
            Assert.Equal(expectedGameResult.WinCard, compareResult.WinCard);
            Assert.Equal(expectedGameResult.WinnerName, compareResult.WinnerName);
        }
    }
}