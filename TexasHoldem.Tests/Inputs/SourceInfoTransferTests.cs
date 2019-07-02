using System;
using TexasHoldem.Core;
using TexasHoldem.Inputs;
using Xunit;

namespace TexasHoldem.Tests.Inputs
{
    public class SourceInfoTransferTests
    {
        private readonly SourceInfoTransfer _sourceInfoTransfer;

        public SourceInfoTransferTests()
        {
            _sourceInfoTransfer = new SourceInfoTransfer();
        }

        [Fact]
        public void ReturnValidHandCardsGivenValidInput()
        {
            var handCards = _sourceInfoTransfer.GetHandCards("2H 3D 5S 9C KD");

            Assert.Equal("2H", handCards.Cards[0]);
            Assert.Equal("3D", handCards.Cards[1]);
            Assert.Equal("5S", handCards.Cards[2]);
            Assert.Equal("9C", handCards.Cards[3]);
            Assert.Equal("KD", handCards.Cards[4]);
        }
    }
}
