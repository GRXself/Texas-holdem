using System.Collections;
using System.Collections.Generic;
using TexasHoldem.Core;
using TexasHoldem.Models;

namespace TexasHoldem.Tests.TestData
{
    public class LevelJudgeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new HandCard() { Cards = new string[] { "2H", "3D", "5S", "9C", "KD" },
                                                        CardValues = new int[] {2, 3, 5, 9, 13}},
                                        Levels.HighCard};
            yield return new object[] { new HandCard() { Cards = new string[] { "2H", "2D", "5S", "9C", "KD" },
                                                        CardValues = new int[] {2, 2, 5, 9, 13}},
                                        Levels.Pair};
            yield return new object[] { new HandCard() { Cards = new string[] { "2H", "2D", "5S", "5C", "KD" },
                                                        CardValues = new int[] {2, 2, 5, 5, 13}},
                                        Levels.TwoPairs};
            yield return new object[] { new HandCard() { Cards = new string[] { "2H", "3D", "4S", "4C", "4H" },
                                                        CardValues = new int[] {2, 3, 4, 4, 4}},
                                        Levels.ThreeOfAKind};
            yield return new object[] { new HandCard() { Cards = new string[] { "TH", "JD", "QD", "KD", "AD" },
                                                        CardValues = new int[] {10, 11, 12, 13, 14}},
                                        Levels.Straight};
            yield return new object[] { new HandCard() { Cards = new string[] { "2H", "3H", "5H", "9H", "KH" },
                                                        CardValues = new int[] {2, 3, 5, 9, 13}},
                                        Levels.Flush};
            yield return new object[] { new HandCard() { Cards = new string[] { "2H", "2D", "4S", "4C", "4H" },
                                                        CardValues = new int[] {2, 2, 4, 4, 4}},
                                        Levels.FullHouse};
            yield return new object[] { new HandCard() { Cards = new string[] { "2H", "4D", "4S", "4C", "4H" },
                                                        CardValues = new int[] {2, 4, 4, 4, 4}},
                                        Levels.FourOfAKind};
            yield return new object[] { new HandCard() { Cards = new string[] { "TD", "JD", "QD", "KD", "AD" },
                                                        CardValues = new int[] {10, 11, 12, 13, 14}},
                                        Levels.StraightFlush};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}