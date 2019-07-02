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

        [Fact]
        public void FormatCardsInRightOrder()
        {
            HandCard handCard = new HandCard();
            string[] cards = new string[]{"2H", "3D", "5S", "9C", "KD"};
            handCard.Cards = cards;

            _cardsOrderFormatter.DescendCardsOrder(handCard);

            for (int i = 0; i < handCard.CardValues.Length - 1; i++)
            {
                Assert.True(handCard.CardValues[i] <= handCard.CardValues[i + 1]);
            }
        }
    }
}