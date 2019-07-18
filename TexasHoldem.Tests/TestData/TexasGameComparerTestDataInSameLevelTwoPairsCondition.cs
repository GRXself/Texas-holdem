using System.Collections;
using System.Collections.Generic;
using TexasHoldEm.Models;

namespace TexasHoldEm.Tests.TestData
{
    public class TexasGameComparerTestDataInSameLevelTwoPairsCondition : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2H 2D 3D 3H KD")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("2C 2S 3S 3C AH")
                },
                new TexasGameResult
                {
                    WinnerName = "White",
                    WinLevel = "high card",
                    WinCard = "Ace"
                }
            },
            new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2H 2D 3D 3H AD")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("2C 2S 3S 3C AH")
                },
                new TexasGameResult
                {
                    WinLevel = "high card",
                }
            },
            new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2H 2D 3D 3H KD")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("2C 2S 4S 4C AH")
                },
                new TexasGameResult
                {
                    WinnerName = "White",
                    WinLevel = "high card",
                    WinCard = "4"
                }
            },
            new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2H 2D 4D 4H KD")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("3C 3S 4S 4C AH")
                },
                new TexasGameResult
                {
                    WinnerName = "White",
                    WinLevel = "high card",
                    WinCard = "3"
                }
            },
            
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}