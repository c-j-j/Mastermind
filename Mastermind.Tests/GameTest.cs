using NUnit.Framework;

namespace Mastermind.Test
{
    [TestFixture]
    public class GameTest
    {
        [Test]
        public void GameWithComputerCodeBreakerEndsInWin()
        {
            var game = new Game(new ComputerCodeMaker("1616", new ScoreCalculator()),
                    new CodeBreaker(new CodeGuesser(new HitCountCalculator())));
            Assert.AreEqual(true, game.Run());
        }
    }
}
