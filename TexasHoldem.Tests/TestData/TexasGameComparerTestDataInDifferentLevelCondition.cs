using System.Collections;
using System.Collections.Generic;
using TexasHoldEm.Models;

namespace TexasHoldEm.Tests.TestData
{
    public class TexasGameComparerTestDataInDifferentLevelCondition : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2H 3H 5H 4H 6H")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("2D 3H 5C 9S KH")
                },
                new TexasGameResult
                {
                    WinnerName = "Black",
                    WinLevel = "straight flush"
                }
            },
            new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2D 2H 2C 2S 6H")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("3D 3H 5C 9S KH")
                },
                new TexasGameResult
                {
                    WinnerName = "Black",
                    WinLevel = "four of a kind"
                }
            },
            new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2H 4S 4C 2D 4H")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("2S 8S AS QS 3S")
                },
                new TexasGameResult
                {
                    WinnerName = "Black",
                    WinLevel = "full house"
                }
            },
            new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2S 8S AS QS 3S")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("3D 3H 5C 9S KH")
                },
                new TexasGameResult
                {
                    WinnerName = "Black",
                    WinLevel = "flush"
                }
            },
            new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2H 3C 5H 4H 6H")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("3D 3H 5C 9S KH")
                },
                new TexasGameResult
                {
                    WinnerName = "Black",
                    WinLevel = "straight"
                }
            },
            new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2D 2H 2C 6H TH")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("3D 3H 5C 9S KH")
                },
                new TexasGameResult
                {
                    WinnerName = "Black",
                    WinLevel = "three of a kind"
                }
            },
            new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2D 2H 6C 6H TH")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("3D 3H 5C 9S KH")
                },
                new TexasGameResult
                {
                    WinnerName = "Black",
                    WinLevel = "two pairs"
                }
            },
            new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("3D 3H 5C 9S KH")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("2H 3C 5S 9C KD")
                },
                new TexasGameResult
                {
                    WinnerName = "Black",
                    WinLevel = "pair"
                }
            },
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}