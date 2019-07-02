using System.Collections.Generic;
using TexasHoldem.Formatter;
using TexasHoldem.Models;
using Xunit;

namespace TexasHoldem.Tests.Formatter
{
    public class CardsOrderFormatterTests
    {
        private CardsOrderFormatter _cardsOrderFormatter;

        public CardsOrderFormatterTests()
        {
            _cardsOrderFormatter = new CardsOrderFormatter();
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void FormatCardsInAscendOrder(string[] cards)
        {
            HandCard handCard = new HandCard();
            handCard.Cards = cards;

            _cardsOrderFormatter.AscendCardsOrder(handCard);

            for (int i = 0; i < handCard.CardValues.Length - 1; i++)
            {
                Assert.True(handCard.CardValues[i] <= handCard.CardValues[i + 1]);
            }
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] {new string[] { "2H", "3D", "5S", "9C", "KD" }},
            new object[] {new string[] { "TH", "3D", "5S", "9C", "KD" }},
            new object[] {new string[] { "2H", "JD", "5S", "9C", "KD" }},
            new object[] {new string[] { "AH", "3D", "QS", "9C", "KD" }},
        };
    }
}