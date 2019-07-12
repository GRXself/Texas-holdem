using System.Collections;
using System.Collections.Generic;
using TexasHoldEm.Core;
using TexasHoldEm.Models;

namespace TexasHoldEm.Tests.TestData
{
    public class TexasGameComparerTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2H 3D 5S 9C KD")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("2C 3H 4S 8C AH")
                },
                new TexasGameResult()
                {
                    WinnerName = "White",
                    WinLevel = "high card",
                    WinCard = "Ace"
                }
            };
            yield return new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2H 3D 5S 9C KD")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("2C 3H 4S 8C KH")
                },
                new TexasGameResult()
                {
                    WinnerName = "Black",
                    WinLevel = "high card",
                    WinCard = "9"
                }
            };
            yield return new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2H 3D 5S 9C KD")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("2D 3H 5C 9S KH")
                },
                new TexasGameResult()
                {
                    WinLevel = "high card",
                    IsTie = true
                }
            };
            yield return new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2H 3H 5H 4H 6H")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("2D 3H 5C 9S KH")
                },
                new TexasGameResult()
                {
                    WinnerName = "Black",
                    WinLevel = "straight flush"
                }
            };
            yield return new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2D 2H 2C 2S 6H")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("3D 3H 5C 9S KH")
                },
                new TexasGameResult()
                {
                    WinnerName = "Black",
                    WinLevel = "four of a kind"
                }
            };
            yield return new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2H 4S 4C 2D 4H")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("2S 8S AS QS 3S")
                },
                new TexasGameResult()
                {
                    WinnerName = "Black",
                    WinLevel = "full house"
                }
            };
            yield return new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2S 8S AS QS 3S")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("3D 3H 5C 9S KH")
                },
                new TexasGameResult()
                {
                    WinnerName = "Black",
                    WinLevel = "flush"
                }
            };
            yield return new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2H 3C 5H 4H 6H")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("3D 3H 5C 9S KH")
                },
                new TexasGameResult()
                {
                    WinnerName = "Black",
                    WinLevel = "straight"
                }
            };
            yield return new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2D 2H 2C 6H TH")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("3D 3H 5C 9S KH")
                },
                new TexasGameResult()
                {
                    WinnerName = "Black",
                    WinLevel = "three of a kind"
                }
            };
            yield return new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("2D 2H 6C 6H TH")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("3D 3H 5C 9S KH")
                },
                new TexasGameResult()
                {
                    WinnerName = "Black",
                    WinLevel = "two pairs"
                }
            };
            yield return new object[] 
            {
                new TexasHoldEmPlayer("Black")
                {
                    HandCards = new HandCards("3D 3H 5C 9S KH")
                }, 
                new TexasHoldEmPlayer("White")
                {
                    HandCards = new HandCards("2H 3C 5S 9C KD")
                },
                new TexasGameResult()
                {
                    WinnerName = "Black",
                    WinLevel = "pair"
                }
            };
            
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}