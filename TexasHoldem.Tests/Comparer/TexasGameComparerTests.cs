using System.Net.NetworkInformation;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
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
//        [ClassData(typeof(TexasGameComparerTestDataInSameLevelHighCardCondition))]
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

        [Fact]
        public void CompareHandCards_BlackPlayerHandCardsBiggerThanWhitePlayerHandCardsByLevel_ReturnBlackWinResult()
        {
            // Arrange
            var blackPlayer = CreateBlackPlayer("2H 3H 5H 4H 6H");
            var whitePlayer = CreateWhitePlayer("2D 3H 5C 9S KH");
            const string EXPECTED_LEVEL = "straight flush";
            const string EXPECTED_WINNERNAME = "Black";
            
            // Act
            var compareResult = TexasGameComparer.CompareHandCards(blackPlayer, whitePlayer);
            
            // Assert
            Assert.Equal(EXPECTED_LEVEL, compareResult.WinLevel);
            Assert.Equal(EXPECTED_WINNERNAME, compareResult.WinnerName);
        }

        private static TexasHoldEmPlayer CreateBlackPlayer(string cardsString)
        {
            return CreatePlayer("Black", cardsString);
        }

        private static TexasHoldEmPlayer CreateWhitePlayer(string cardsString)
        {
            return CreatePlayer("White", cardsString);
        }

        private static TexasHoldEmPlayer CreatePlayer(string playerName, string cardsString)
        {
            return new TexasHoldEmPlayer(playerName) 
            {
                HandCards = new HandCards(cardsString),
            };
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