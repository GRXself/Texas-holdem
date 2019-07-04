using TexasHoldem.Core;
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
        [ClassData(typeof(LevelJudgeTestData))]
        public void ReturnRightLevel(HandCard handCard, Levels expectedLevel)
        {
            _levelJudger.JudgeLevel(handCard);

            Assert.Equal(expectedLevel, handCard.Level);
        }
    }
}