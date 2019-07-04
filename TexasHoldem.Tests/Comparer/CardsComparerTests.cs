using TexasHoldem.Comparer;
using TexasHoldem.Models;
using TexasHoldem.Tests.TestData;
using Xunit;

namespace TexasHoldem.Tests.Comparer
{
    public class CardsComparerTests
    {
        private CardsComparer _cardsComparer;

        public CardsComparerTests()
        {
            _cardsComparer = new CardsComparer();
        }

        [Theory]
        [ClassData(typeof(CardsComparerTestData))]
        public void ReturnCompareResultGivenTwoProcessHandCard(HandCard[] handCards, string compareResult)
        {
            Assert.Equal(compareResult, _cardsComparer.CompareCards(handCards));
        }
    }
}