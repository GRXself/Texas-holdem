using TexasHoldEm.Comparer;
using TexasHoldEm.Models;
using TexasHoldEm.Tests.TestData;
using Xunit;

namespace TexasHoldEm.Tests.Comparer
{
    public class TexasGameComparerTests
    {
        [Theory]
        [ClassData(typeof(TexasGameComparerTestDataInDifferentLevelCondition))]
        public void ReturnCompareResultGivenTwoReadyPlayersInDifferentLevelCondition(
            TexasHoldEmPlayer blackPlayer, 
            TexasHoldEmPlayer whitePlayer,
            TexasGameResult expectedGameResult)
        {
            GetCompareResult(blackPlayer, whitePlayer, expectedGameResult);
        }

        [Theory]
        [ClassData(typeof(TexasGameComparerTestDataInSameLevelHighCardCondition))]
        public void ReturnCompareResultGivenTwoReadyPlayersInSameLevelHighCardCondition(
            TexasHoldEmPlayer blackPlayer, 
            TexasHoldEmPlayer whitePlayer,
            TexasGameResult expectedGameResult)
        {
            GetCompareResult(blackPlayer, whitePlayer, expectedGameResult);
        }
        
        [Theory]
        [ClassData(typeof(TexasGameComparerTestDataInSameLevelTwoPairsCondition))]
        public void ReturnCompareResultGivenTwoReadyPlayersInSameLevelTwoPairsCondition(
            TexasHoldEmPlayer blackPlayer, 
            TexasHoldEmPlayer whitePlayer,
            TexasGameResult expectedGameResult)
        {
            GetCompareResult(blackPlayer, whitePlayer, expectedGameResult);
        }
        
        [Theory]
        [ClassData(typeof(TexasGameComparerTestDataInSameLevelFullHouseCondition))]
        public void ReturnCompareResultGivenTwoReadyPlayersInSameLevelFullHouseCondition(
            TexasHoldEmPlayer blackPlayer, 
            TexasHoldEmPlayer whitePlayer,
            TexasGameResult expectedGameResult)
        {
            GetCompareResult(blackPlayer, whitePlayer, expectedGameResult);
        }

        private static void GetCompareResult(TexasHoldEmPlayer blackPlayer, TexasHoldEmPlayer whitePlayer,
            TexasGameResult expectedGameResult)
        {
            var compareResult = TexasGameComparer.CompareHandCards(blackPlayer, whitePlayer);
            Assert.Equal(expectedGameResult.WinLevel, compareResult.WinLevel);
            Assert.Equal(expectedGameResult.WinCard, compareResult.WinCard);
            Assert.Equal(expectedGameResult.WinnerName, compareResult.WinnerName);
        }
    }
}