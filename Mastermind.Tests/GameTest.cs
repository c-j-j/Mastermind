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
                    new ComputerCodeBreaker(new NegamaxCodeGuesser(new HitCountCalculator())));
            Assert.AreEqual(true, game.Run());
        }
    }
}
