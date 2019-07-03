using TexasHoldem.Level;
using TexasHoldem.Models;
using TexasHoldem.Tests.TestData;
using Xunit;

namespace TexasHoldem.Tests.Level
{
    public class LevelJudgerTests
    {
        private LevelJudger _levelJudger;

        public LevelJudgerTests()
        {
            _levelJudger = new LevelJudger();
        }

        [Theory]
        [ClassData((typeof(HandCardTestData)))]
        public void ReturnRightLevel(HandCard handCard, int expectedLevel)
        {
            _levelJudger.JudgeLevel(handCard);

            Assert.Equal(expectedLevel, handCard.Level);
        }
    }
}