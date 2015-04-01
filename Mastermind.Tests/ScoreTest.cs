using NUnit.Framework;

namespace Mastermind.Test
{
    [TestFixture]
    public class ScoreTest
    {
        [Test]
        public void ScoreWithNoPegsHasNoWhiteOrBlackPegs()
        {
            Assert.AreEqual(0, new Score().NumberOfBlackPegs);
            Assert.AreEqual(0, new Score().NumberOfBlackPegs);
        }

        [Test]
        public void ScoreWithGivenPegs()
        {
            Assert.AreEqual(1, new Score(1, 2).NumberOfBlackPegs);
            Assert.AreEqual(2, new Score(1, 2).NumberOfWhitePegs);
        }

        [Test]
        public void AddsBlackPeg()
        {
            var score = new Score();
            score.AddBlackPeg();
            Assert.AreEqual(1, score.NumberOfBlackPegs);
        }

        [Test]
        public void AddsWhitePeg()
        {
            var score = new Score();
            score.AddWhitePeg();
            Assert.AreEqual(1, score.NumberOfWhitePegs);
        }

        [Test]
        public void ScoreWithSameBlackAndWhitePegsAreEqual()
        {
            var score = new Score();
            Assert.AreEqual(true, score.EqualTo(new Score()));
        }

        [Test]
        public void ScoreWithDifferentBlackPegsAreNotEqual()
        {
            var score = new Score(1, 0);
            Assert.AreEqual(false, score.EqualTo(new Score()));
        }

        [Test]
        public void ScoreWithDifferentWhitePegsAreNotEqual()
        {
            var score = new Score(0, 1);
            Assert.AreEqual(false, score.EqualTo(new Score()));
        }

        [Test]
        public void CreatesScoreWithString()
        {
            Assert.AreEqual(1, new Score("B").NumberOfBlackPegs);
            Assert.AreEqual(2, new Score("WW").NumberOfWhitePegs);
        }

    }
}
