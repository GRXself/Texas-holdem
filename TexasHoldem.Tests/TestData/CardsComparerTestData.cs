using System.Collections;
using System.Collections.Generic;
using TexasHoldem.Core;
using TexasHoldem.Models;

namespace TexasHoldem.Tests.TestData
{
    public class CardsComparerTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] 
            {
                new HandCard[]
                {
                    new HandCard()
                    {   
                        Level = Levels.HighCard,
                        Cards = new string[] { "2H", "3D", "5S", "9C", "KD" },
                        CardValues = new int[] {2, 3, 5, 9, 13}
                    },
                    new HandCard()
                    {   
                        Level = Levels.HighCard,
                        Cards = new string[] { "2C", "3H", "4S",  "8C", "AH" },
                        CardValues = new int[] {2, 3, 4, 8, 14}
                    }
                },
                "White wins - HighCard: Ace"
            };
            yield return new object[] 
            {
                new HandCard[]
                {
                    new HandCard()
                    {   
                        Level = Levels.FullHouse,
                        Cards = new string[] { "2H", "4S", "4C", "2D", "4H" },
                        CardValues = new int[] {2, 2, 4, 4, 4}
                    },
                    new HandCard()
                    {   
                        Level = Levels.HighCard,
                        Cards = new string[] { "2S", "8S", "AS", "QS", "3S" },
                        CardValues = new int[] {2, 3, 8, 12, 14}
                    }
                },
                "Black wins - FullHouse"
            };
            yield return new object[] 
            {
                new HandCard[]
                {
                    new HandCard()
                    {   
                        Level = Levels.Pair,
                        Cards = new string[] { "2H", "2D", "5S", "9C", "TD" },
                        CardValues = new int[] {2, 2, 5, 9, 10}
                    },
                    new HandCard()
                    {   
                        Level = Levels.Pair,
                        Cards = new string[] { "2S", "2C", "JS", "QS", "3S" },
                        CardValues = new int[] {2, 2, 3, 11, 12}
                    }
                },
                "White wins - HighCard: Q"
            };
            yield return new object[] 
            {
                new HandCard[]
                {
                    new HandCard()
                    {   
                        Level = Levels.HighCard,
                        Cards = new string[] { "2H", "3D", "5S", "9C", "KD" },
                        CardValues = new int[] {2, 3, 5, 9, 13}
                    },
                    new HandCard()
                    {   
                        Level = Levels.HighCard,
                        Cards = new string[] { "2D", "3H", "5C", "9S", "KH" },
                        CardValues = new int[] {2, 3, 5, 9, 13}
                    }
                },
                "Tie"
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}