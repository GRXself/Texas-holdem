using System.Collections;
using System.Collections.Generic;
using TexasHoldEm.Models;

namespace TexasHoldEm.Tests.TestData
{
    public class TexasGameComparerTestDataInSameLevelHighCardCondition : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2H 3D 5S 9C KD")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("2C 3H 4S 8C AH")
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
                    HandCards = new HandCards("2H 3D 5S 9C KD")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("2C 3H 4S 8C KH")
                },
                new TexasGameResult
                {
                    WinnerName = "Black",
                    WinLevel = "high card",
                    WinCard = "9"
                }
            },
            new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2H 3D 5S 9C KD")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("2D 3H 5C 9S KH")
                },
                new TexasGameResult
                {
                    WinLevel = "high card",
                }
            },
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}