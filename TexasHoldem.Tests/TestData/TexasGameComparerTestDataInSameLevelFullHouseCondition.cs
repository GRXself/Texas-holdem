using System.Collections;
using System.Collections.Generic;
using TexasHoldEm.Models;

namespace TexasHoldEm.Tests.TestData
{
    public class TexasGameComparerTestDataInSameLevelFullHouseCondition : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2H 2D 3D 3H 3D")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("2C 2S 4S 4C 4H")
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
                    HandCards = new HandCards("JH JD 5D 5H 5D")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("KC KS 4S 4C 4H")
                },
                new TexasGameResult
                {
                    WinnerName = "Black",
                    WinLevel = "high card",
                    WinCard = "5"
                }
            },
            
        };
        
        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}